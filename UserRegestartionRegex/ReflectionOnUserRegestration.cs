using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace UserRegestartionRegex
{
     class ReflectionOnUserRegestration
    {
        public static void ReflectionTest()
        {
            Type type = Type.GetType("UserRegestartionRegex.RegestrationRegexPattern");
            Console.WriteLine("Full Name is : " + type.FullName);
            Console.WriteLine("Class Name is : " + type.Name);
            Console.WriteLine("Methods in class are : ");
            MethodInfo[] methodinfo = type.GetMethods();
            foreach (var method in methodinfo)
            {
                Console.WriteLine(method.ReturnType.Name+"  "+method.Name);
            }
            PropertyInfo[] propertyInfo = type.GetProperties();
            Console.WriteLine("Properties in class are :");
            foreach (var property in propertyInfo)
            {
                Console.WriteLine(property.PropertyType.Name + "  " + property.Name);
            }
            Console.WriteLine();
            Type type1 = Type.GetType("UserRegestartionRegex.RegistrationCustomExceptions");
            Console.WriteLine("Full Name is : " + type1.FullName);
            Console.WriteLine("Class Name is : " + type1.Name);
            PropertyInfo[] propertyInfo1 = type.GetProperties();
            Console.WriteLine("Properties in class are :");
            foreach (var property in propertyInfo1)
            {
                Console.WriteLine(property.PropertyType.Name + "  " + property.Name);
            }
            Console.WriteLine("Constructors in class are :");
            ConstructorInfo[] constructorInfo = type1.GetConstructors();
            foreach (var constructors in constructorInfo)
            {
                Console.WriteLine(constructors.ToString());
            }
        }
    }
}

