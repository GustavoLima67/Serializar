using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using _00_Biblioteca;
using System.Xml.Serialization;

namespace _01_SerializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "José Costa Silva", CPF = "222.222.222.22", Email = "jose@gmail.com" };

            XmlSerializer xmlSrl = new XmlSerializer(typeof(Usuario));

            StreamWriter sw = new StreamWriter(@"C:\Users\Gustavo\Documents\Arquivos c#\01_SerializarXML.xml");
            
            xmlSrl.Serialize(sw, usuario);

        }
    }
}
