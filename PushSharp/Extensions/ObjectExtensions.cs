using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PushSharp.Extensions
{
    internal static class ObjectExtensions
    {
        /// <summary>
        /// Maximum number of items to store in our Dictionary
        /// </summary>
        private const int MAX_CACHED_IL_ENTRIES = 1000;

        /// <summary>
        /// This dictionary caches the delegates for each 'to-clone' type.
        /// </summary>
        private static Dictionary<Type, Delegate> _cachedIL = new Dictionary<Type, Delegate>();

        /// <summary>
        /// http://whizzodev.blogspot.com/2008/03/object-cloning-using-il-in-c.html
        /// Generic cloning method that clones an object using IL.
        /// Only the first call of a certain type will hold back performance.
        /// After the first call, the compiled IL is executed.
        /// NOT intended to be ThreadSafe.
        /// </summary>
        /// <typeparam name="T">Type of object to clone</typeparam>
        /// <param name="myObject">Object to clone</param>
        /// <returns>Cloned object</returns>
        internal static T CloneObjectWithIL<T>(this T myObject)
        {
            // Probably not needed but we don't want our Dictionary to grow infinitely in long running programs
            while (_cachedIL.Count > MAX_CACHED_IL_ENTRIES)
            {
                _cachedIL.Remove(_cachedIL.First().Key);
            }

            Delegate myExec = null;
            if (!_cachedIL.TryGetValue(typeof(T), out myExec))
            {
                // Create ILGenerator
                DynamicMethod dymMethod = new DynamicMethod("DoClone", typeof(T), new Type[] { typeof(T) }, true);
                ConstructorInfo cInfo = myObject.GetType().GetConstructor(new Type[] { });

                ILGenerator generator = dymMethod.GetILGenerator();

                LocalBuilder lbf = generator.DeclareLocal(typeof(T));

                generator.Emit(OpCodes.Newobj, cInfo);
                generator.Emit(OpCodes.Stloc_0);
                foreach (FieldInfo field in myObject.GetType().GetFields(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic))
                {
                    // Load the new object on the eval stack... (currently 1 item on eval stack)
                    generator.Emit(OpCodes.Ldloc_0);
                    // Load initial object (parameter)          (currently 2 items on eval stack)
                    generator.Emit(OpCodes.Ldarg_0);
                    // Replace value by field value             (still currently 2 items on eval stack)
                    generator.Emit(OpCodes.Ldfld, field);
                    // Store the value of the top on the eval stack into the object underneath that value on the value stack.
                    //  (0 items on eval stack)
                    generator.Emit(OpCodes.Stfld, field);
                }

                // Load new constructed obj on eval stack -> 1 item on stack
                generator.Emit(OpCodes.Ldloc_0);
                // Return constructed object.   --> 0 items on stack
                generator.Emit(OpCodes.Ret);

                myExec = dymMethod.CreateDelegate(typeof(Func<T, T>));
                _cachedIL.Add(typeof(T), myExec);
            }
            return ((Func<T, T>)myExec)(myObject);
        }
    }
}
