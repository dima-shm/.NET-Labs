using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Xml;

namespace Lab_5
{
    static class Reflector
    {
        static public void WriteToFileAllContent(string objName)
        {
            Type myType = Type.GetType("Lab_5." + objName, false, true);

            File.WriteAllText("1.AllContent.txt", "Methods of class " + myType.Name + ":");
            foreach (MethodInfo method in myType.GetMethods())
            {
                string modificator = "";

                if (method.IsStatic)
                    modificator += "static ";
                if (method.IsVirtual)
                    modificator += "virtual ";

                File.AppendAllText("1.AllContent.txt", "\r\n ● " + modificator + method.ReturnType.Name + " " + method.Name + " (");
                // Get all params
                ParameterInfo[] parameters = method.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    File.AppendAllText("1.AllContent.txt", parameters[i].ParameterType.Name + " " + parameters[i].Name);
                    if (i + 1 < parameters.Length) File.AppendAllText("1.AllContent.txt", ", ");
                }
                File.AppendAllText("1.AllContent.txt", ")");
            }
            File.AppendAllText("1.AllContent.txt", "\r\n\r\nFields:");
            foreach (FieldInfo field in myType.GetFields())
            {
                File.AppendAllText("1.AllContent.txt", "\r\n ● " + field.FieldType + field.Name);
            }

            File.AppendAllText("1.AllContent.txt", "\r\n\r\nProperties:");
            foreach (PropertyInfo prop in myType.GetProperties())
            {
                File.AppendAllText("1.AllContent.txt", "\r\n ● " + prop.PropertyType + prop.Name);
            }
        }
        static public void WriteToFileAllPublicMethods(string objName)
        {
            Type myType = Type.GetType("Lab_5." + objName, false, true);

            File.WriteAllText("2.AllPublicMethods.txt", "Methods of class " + myType.Name + ":");
            foreach (MethodInfo method in myType.GetMethods())
            {
                string modificator = "";

                if (method.IsStatic)
                    modificator += "static ";
                if (method.IsVirtual)
                    modificator += "virtual ";

                File.AppendAllText("2.AllPublicMethods.txt", "\r\n ● " + modificator + method.ReturnType.Name + " " + method.Name + " (");
                // Get all params
                ParameterInfo[] parameters = method.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    File.AppendAllText("2.AllPublicMethods.txt", parameters[i].ParameterType.Name + " " + parameters[i].Name);
                    if (i + 1 < parameters.Length) File.AppendAllText("2.AllPublicMethods.txt", ", ");
                }
                File.AppendAllText("2.AllPublicMethods.txt", ")");
            }
        }
        static public void WriteToFileFieldAndProperties(string objName)
        {
            Type myType = Type.GetType("Lab_5." + objName, false, true);

            File.WriteAllText("3.FieldAndProperties.txt", "Fields:");
            foreach (FieldInfo field in myType.GetFields())
            {
                File.AppendAllText("3.FieldAndProperties.txt", "\r\n ● " + field.FieldType + field.Name);
            }

            File.AppendAllText("3.FieldAndProperties.txt", "\r\n\r\nProperties:");
            foreach (PropertyInfo prop in myType.GetProperties())
            {
                File.AppendAllText("3.FieldAndProperties.txt", "\r\n ● " + prop.PropertyType + prop.Name);
            }
        }
        static public void WriteToFileImplementedInterfaces(string objName)
        {
            Type myType = Type.GetType("Lab_5." + objName, false, true);

            File.WriteAllText("4.ImplementedInterfaces.txt", "Implemented Interfaces:");
            foreach (Type i in myType.GetInterfaces())
            {
                File.AppendAllText("4.ImplementedInterfaces.txt", "\r\n ● " + i.Name);
            }
        }
        static public void WriteToFileNameOfMethodsWithSpecifiedType(string objName, string specifiedType)
        {
            Type myType = Type.GetType("Lab_5." + objName, false, true);

            File.WriteAllText("5.MethodsWithSpecifiedType.txt", "Methods with specified type " + specifiedType + ":");
            foreach (MethodInfo method in myType.GetMethods())
            {
                ParameterInfo[] parameters = method.GetParameters();
                for (int i = 0; i < parameters.Length; i++)
                {
                    if (parameters[i].ParameterType.Name == specifiedType)
                        File.AppendAllText("5.MethodsWithSpecifiedType.txt", "\r\n ● " + method.Name);
                }
            }
        }
        static public void ReadArgsMethodFromFile(string className, string methodName)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("6.Method.xml");
            XmlNodeList ordersList = doc.DocumentElement.ChildNodes;

            object[] param = new object[4];
            int i = 0;

            foreach (XmlNode n in ordersList)
            {
                if (n.Name == "method" && n.Attributes["id"].Value == "Color_Message")
                {
                    foreach (XmlNode tmp in n)
                    {
                        param[i] = tmp.InnerText;
                        i++;
                    }
                }
            }
            Type myClass = Type.GetType(className);
            MethodInfo mi = myClass.GetMethod(methodName);
            mi.Invoke(null, new object[] { param });
        }
    }

    public static class MyClass
    {
        public static void Color_Message(params object[] message)
        {
            // Set color
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < message.Length; i++)
            {
                Console.WriteLine(message[i]);
            }
            // reset collor settings
            Console.ResetColor();
        }
    }
}