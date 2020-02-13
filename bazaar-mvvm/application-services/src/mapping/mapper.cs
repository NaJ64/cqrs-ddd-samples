using System;
using System.Reflection;

namespace Bazaar.ApplicationServices.Mapping
{
    public static class Mapper
    { 
        public static T MapTo<T>(this object source) where T : class
        {
            // TODO:  Copy all the props from source
            return Activator.CreateInstance(typeof(T)) as T;
        }
    }
}