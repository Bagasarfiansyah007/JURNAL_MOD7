using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;
namespace jurnal_mod7
{
    public class GlossaryItem_1302194007
    {
        public CGlossary glossary { get; set; }

        public GlossaryItem_1302194007() { }

        public GlossaryItem_1302194007 ReadJSON()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string jsonString = File.ReadAllText(path + "/jurnal7_3_1302194007.json");
            return JsonSerializer.Deserialize<GlossaryItem_1302194007>(jsonString);
        }
    }

    public class CGlossary
    {
        public string title { get; set; }
        public CGlossDiv GlossDiv { get; set; }

    }

    public class CGlossDiv
    {
        public string title { get; set; }
        public CGlossList GlossList { get; set; }

    }

    public class CGlossList
    {
        public CGlossEntry GlossEntry { get; set; }

    }

    public class CGlossEntry
    {
        public string ID { get; set; }
        public string SortAs { get; set; }
        public string GlossTerm { get; set; }
        public string Acronym { get; set; }
        public string Abbrev { get; set; }
        public CGlossDef GlossDef { get; set; }
        public string GlossSee { get; set; }

    }

    public class CGlossDef
    {
        public string para { get; set; }
        public List<string> GlossSeeAlso { get; set; }

    }
}
