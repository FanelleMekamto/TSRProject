using System;
using System.Collections.Generic;
using System.Text;

namespace TSR.DAL
{
    static class Data
    {
        public static List<string> ListNiveauScolarite = new List<string> { 
            "Selectionner...", 
            "Aucun, étude secondaire non complétée", 
            "Diplôme d'études secondaire",
            "Programme d'un an d'université/collège/école technique/école métier/autre établissement",
            "Programme de deux ans d'université/collège/école technique/école métier/autre établissement",
            "Baccalauréat (Programme d'une université/collège/école technique/école métier/autre établissement",
            "Au moins 2 certificats/grades/diplomes, à la suite d'un prog d'études seconadaire d'au moins 3 ans.",
            "Maitrise ou diplôme professionnel",
            "Diplôme universitaire au niveau du doctorat(PhD)"

        };

        public static List<String> ListAutreTest1 = new List<String>
        {
            "Selectionner...",
            "TEF Canada",
            "TCF Canada",
            "Sans Objet"
        };

        public static List<String> ListAutreTest2 = new List<String>
        {
            "Selectionner...",
            "CELPIP-G Canada",
            "IELTS Canada",
            "Sans Objet"
        };

        public static List<string> listNotesCELPIPG = new List<string>
        {
           "Selectionner...",
            "10-12",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "M, 0-3"
        };

        public static List<string> listNotes_EOEE_IELTS = new List<string>
        {
            "Selectionner...",
            "7.5 - 9.0",
            "7.0",
            "6.5",
            "6.0",
            "5.5",
            "5.0",
            "4.0 - 4.5",
            "0 - 3.5"
        };

        public static List<string> listNotes_CO_IELTS = new List<string>
        {
            "Selectionner...",
            "8.5 - 9.0",
            "8.0",
            "7.5",
            "6.0 - 7.0",
            "5.5",
            "5.0",
            "4.5",
            "0 - 4.0"
        };

        public static List<string> listNotes_CE_IELTS = new List<string>
        {
            "Selectionner...",
            "8.0 - 9.0",
            "7.0 - 7.5",
            "6.5",
            "6.0",
            "5.0 - 5.5",
            "4.0 - 4.5",
            "3.5",
            "0 - 3.0"
        };

        public static List<string> listNotes_EOEE_TEF = new List<string>
        {
            "Selectionner...",
            "393 - 450",
            "371 - 392",
            "349 - 370",
            "310 - 348",
            "271 - 309",
            "226 - 270",
            "181 - 225",
            "0 - 180"
        };

        public static List<string> listNotes_CO_TEF = new List<string>
        {
            "Selectionner...",
            "316 - 360",
            "298 - 315",
            "280 - 297",
            "249 - 279",
            "217 - 309",
            "181 - 216",
            "145 - 180",
            "0 - 144"
        };

        public static List<string> listNotes_CE_TEF = new List<string>
        {
            "Selectionner...",
            "263 - 300",
            "248 - 262",
            "233 - 247",
            "207 - 232",
            "181 - 206",
            "151 - 180",
            "121 - 150",
            "0 - 120"
        };

        public static List<string> listNotes_EOEE_TCF = new List<string>
        {
            "Selectionner...",
            "16 - 20",
            "14 - 15",
            "12 - 13",
            "10 - 11",
            "7 - 9",
            "6",
            "4 - 5",
            "0 - 3"
        };

        public static List<string> listNotes_CO_TCF = new List<string>
        {
            "Selectionner...",
            "549 - 699",
            "523 - 548",
            "503 - 522",
            "458 - 502",
            "498 - 457",
            "369 - 397",
            "331 - 368",
            "0 - 330"
        };

        public static List<string> listNotes_CE_TCF = new List<string>
        {
            "Selectionner...",
            "549 - 699",
            "524 - 548",
            "499 - 523",
            "453 - 498",
            "406 - 452",
            "375 - 405",
            "342 - 374",
            "0 - 341"
        };
    }
}
