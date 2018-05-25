using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Task4.Properties
{

    public class FileHandlerAsync
    {
        private const int DEFAULT_BUFFER_SIZE = 4096;
        ///Das @ ist nicht zwingend aber von Vorteil, wenn man einen Pfad vom Windows Explorer direkt in den C# Code kopiert denn er verhindert, 
        ///dass der Schrägstrich mit Kombination von gewissen Buchstaben als Spezialzeichen angesehen werden. 

        public static async Task<string> ReadAllLinesAsync(string @path)
        {

         
            ///Danach überprüfe ich, ob die angegebene Datei existiert, wenn nicht werfe ich eine ArgumentException.
            if (!File.Exists(path)) throw new ArgumentException($"The File {path} doesn't exist");

            ///Zum Lesen wird die Datei einfach geöffnet deshalb FileMode.Open. Der FileMode beschreibt, in welcher Form die Datei behandelt wird.
            ///Der FileAcces habe ich hier auf ReadWrite gestellt auch wenn Read reichen würde. Der FileAcces beschreibt, welche rechte man mit der Datei hat.
            ///Ob man lesen oder lesen und schreiben darf. Beim FileShare Parameter geht es darum zu bestimmen, mit welchen Rechten andere Prozesse auf die Datei zugreifen können. 
            ///Bei den FileOptions geht es darum, dass die Datei asynchron behandelt wird und speziell FileAcces.
            ///SequentialScan um die Datei sequenziell zu lesen, sodass das Zwischenspeichern der Datei optimiert wird. 

            using (var stream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite, FileShare.Read, DEFAULT_BUFFER_SIZE, FileOptions.Asynchronous | FileOptions.SequentialScan))

                ///Zusätzlich wird alles mit UTF-8 Zeichensatz codiert respektive decodiert. Schlussendlich gebe ich die ganze Datei als string zurück.

            using (var reader = new StreamReader(stream, Encoding.UTF8))
            {
                return await reader.ReadToEndAsync();
            }
        }

    }
}