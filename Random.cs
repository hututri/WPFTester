using System.Linq;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Data;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ConsoleApp
{

    public class SomeClass
    {
        public int i { get; set; }

        public SomeClass() { }



    }
    public class Randomizer
    {
        private static Random rand { get; set; }
        private static List<string> LipsumWords, MetalWords, MetalNames, DemonWords;
        static Randomizer()
        {
            rand = new Random();
            LipsumWords = new List<string>
                {
                    "a","ac","accumsan","adipiscing","Aenean","aliquam","aliquet","amet","ante","arcu","at",
                    "auctor","augue","bibendum","blandit","commodo","condimentum","congue","consectetur",
                    "consequat","convallis","Cras","Cum","Curabitur","cursus","dapibus","diam","dictum",
                    "dignissim","dis","dolor","Donec","dui","Duis","egestas","eget","eleifend","elementum",
                    "elit","enim","erat","eros","est","et","Etiam","eu","euismod","facilisis","fames","faucibus",
                    "felis","fermentum","feugiat","fringilla","Fusce","gravida","habitant","hendrerit","iaculis",
                    "id","imperdiet","in","Integer","interdum","ipsum","justo","lacinia","lacus","laoreet",
                    "lectus","leo","libero","ligula","lobortis","lorem","luctus","Maecenas","magna","magnis",
                    "malesuada","massa","mattis","Mauris","metus","mi","molestie","mollis","montes","morbi",
                    "mus","Nam","nascetur","natoque","nec","neque","netus","nibh","nisi","nisl","non","nulla",
                    "Nullam","nunc","odio","orci","ornare","parturient","pellentesque","penatibus","pharetra",
                    "Phasellus","placerat","porta","porttitor","posuere","Praesent","pretium","Proin","pulvinar",
                    "purus","quam","quis","Quisque","rhoncus","ridiculus","risus","rutrum","sagittis","sapien",
                    "scelerisque","sed","sem","semper","senectus","sit","sociis","sodales","sollicitudin",
                    "suscipit","Suspendisse","tellus","tempor","tempus","tincidunt","tortor","tristique",
                    "turpis","ullamcorper","ultrices","ultricies","urna","ut","varius","vehicula","vel","velit",
                    "venenatis","vestibulum","vitae","Vivamus","viverra","volutpat","vulputate"
                };

            MetalNames = new List<string>
            {
                "!–9","!T.O.O.H.!","Abaddon Incarnate","Abated Mass of Flesh","Abhorrence","Ablaze My Sorrow","Aborted","Abramelin","Abscess","The Absence","Abysmal Dawn","Abysmal Torment","Acheron","Acid Bath","Aeon","Aeternus","Afflicted","The Agonist","Akercocke","Alchemist","Aletheian","Altar","The Amenta","Amon Amarth","Amoral","Amorphis","Anata","Anathema","Angelcorpse","Animosity","Antestor ","Anvil of Doom","Die Apokalyptischen","Reiter", "Arch Enemy","Archeon","Architects","Arise","Armageddon","Armoured Angel","Arsis","As I Lay Dying","Asesino","Asphyx","Assück","At the Gates","Atheist","Atrocity","Atrophia Red Sun","Austrian Death Machine","Autopsy","Autopsy Torment","Avuls","Battlelore","Becoming the Archetype","Beheaded","Behemoth","Belphegor","Benea Reach","Beneath the Massacre","Benediction","Benighted","The Berzerker","Bestial Warlust","Between the Buried and Me","Beyond the Sixth Seal","Bilocate","The Black Dahlia Murder","Blinded Colony","Blo.Torch","Blood Duster","Blood Red Throne","Blood Stain Child","Bloodbath","Bolt Thrower","Born of Osiris","Brain Drill","Brodequin","Broken Hope","Brujeria","Brutal Truth","Burning Inside","By Night","Cadacross","Cadaver","Callenish Circle","Cancer","Caninus","Cannibal Corpse","Capharnaum","Carbonized","Carcass","Cardinal Sin","Carnage","Carnival in Coal","Cattle Decapitation","Cavalera","Conspiracy", "Celtic Frost","Cemetary","Cenotaph","Centinex","Cephalic Carnage","Ceremonial Oath","Chain Collector","Changer","The Chasm","Children of Bodom","Circle of Dead Children","Coldworker","Comecon","The Concubine","Condemned","Consolation","Coprofago","Corpus Mortale","The County Medical Examiners","Cradle of Filth","The","Crimson Armada", "Crimson Death","Crimson Thorn","Crionics","The Crown","Cryogenic","Cryptopsy","Cynic","Dååth","Dam","Damaged","Dance","Club Massacre","Dark Age","Dark Heresy","Dark Lunacy","Dark Tranquillity","Darkest Hour","Darkthrone","Dawn of Azazel","Daylight Dies","Dead Horse","Dead Infection","Deadlock","Death","Death Breath","Death Organ","Death Requisite","Deathbound","Deathchain","Debauchery","Decadence","Decapitated","Deceased","Decrepit Birth","Deeds of Flesh","Defeated Sanity","Defecation","Defleshed","Deicide","Demenzia","Demigod","Demilich","Demiricous","Demonoid","Desecration","Despised","Icon","Despite","Destroy Destroy Destroy","Desultory","Dethklok","Detonation","Deuteronomium","Devian","DevilDriver","Devilish Impressions","Devolved","Devourment","Diablo","Diabolic","Dies Irae","A Different Breed of Killer","Dim Mak","Dimension","Zero","Disarmonia Mundi","Disavowed","Disbelief","Disentomb","Disgorge","Disharmonic Orchestra","Disillusion","Disincarnate","Diskreet","Dismember","Diocletian","Dispatched","Dissection","Distorted","Divine","Heresy", "Dominion", "Dominus", "Dr. Shrinker", "Drottnar", "The Duskfall", "Dying Fetus", "Dylath Leen", "Ebony Tears", "Edge of Sanity", "Elysia", "Elysium", "Embalmer", "Embodyment", "Ensiferum", "Entombed", "Epoch of Unlight", "Eternal Lord", "Eternal Oath", "Eternal Tears of Sorrow", "Eucharist", "Evoken", "Ex Deo", "Exhumed", "Expulsion", "Extol", "Extreme Noise Terror", "Face Down", "The Faceless", "The Fading", "Falchion", "Farmakon", "Fear Factory", "Fear My Thoughts","Festerday", "Fission", "Fleshcrawl", "Fleshgod Apocalypse", "Fragments of Unbecoming", "From a Second Story", "Window", "From the Shallows", "Frontside", "The Funeral Pyre", "Gandalf", "Gates of Ishtar", "The Gathering", "Gehenna", "General Surgery", "Ghost Brigade", "Ghoul", "Glass Casket", "Goatlord", "Goatwhore", "God Dethroned", "God Forbid", "God", "Macabre", "Godgory", "Gojira", "Gone Postal", "Goreaphobia", "Gorefest", "Gorelord", "Gorerotted", "Gorguts", "Gory Blister", "Grave", "Graves of Valor", "Grenouer", "Grief of War", "Grotesque", "Gut", "Gutworm", "Hacride", "Haemorrhage", "Haggard", "Hate", "Hate Eternal", "Hatebeak", "Hatesphere", "The Haunted", "Hearse", "Heaven Shall Burn", "Hecate Enthroned", "Hellhammer", "Helltrain", "Hibernus Mortis", "Hollenthon", "Human", "Human Remains", "Hybrid", "Hypocrisy", "Illdisposed", "Immolation", "Immortal Souls", "Impaled", "Impaled Nazarene", "Impending Doom", "Impetigo", "Impious", "In Battle", "In Flames", "In Mourning", "In-Quest", "Incantation", "Inevitable End", "Infernäl Mäjesty", "Infernal Method", "Inhumate", "Inhume", "Iniquity", "Insision", "Insomnium", "Internal Suffering", "Into Eternity", "Into the Moat", "Job for a Cowboy", "Jungle Rot", "Kaamos", "Kalmah", "Katafalk", "Kataklysm", "Katatonia", "Kekal", "Killing Addiction", "Kinetic", "Knights of the Abyss", "Konkhra", "Krabathor", "Krisiun", "Kronos", "In Hell", "At Night", "To The Death","Crucifixion" };

            DemonWords = new List<string>{
                "Abaddon", "Apollyon", "Abigor", "Adramelech", "Agares", "Alocer", "Amduscius", "Andras", "Asmoday", "Asmodeus", "Astaroth", "Aym", "Ayperos", "Azazel", "Bael", "Balam", "Beelzebub", "Belial", "Belphegor", "Berith", "Bifrons", "Botis", "Buer", "Caym", "Charon", "Cresil", "Crocell", "Deumos", "Eurynome", "Focalor", "Furfur", "Gaap", "Geryon", "Haures", "Ipos", "Jezebeth", "Kasdeya", "Kobal", "Leonard", "Leviathan", "Lilith", "Lucifer", "Malphas", "Mammon", "Mastema", "Melchom", "Mephistopheles", "Merihim", "Moloch", "Mullin", "Murmur", "Naberius", "Nergal", "Nicor", "Nybbas", "Nysrogh", "Oriax", "Ornias", "Ose", "Paymon", "Philatanus", "Proserpine", "Pruflas", "Pyro", "Raum", "Rimmon", "Ronove", "Ronwe", "Samael", "Semiazas", "Shax", "Shalbriri", "Sonneillon", "Stolas", "Succorbenoth", "Thamuz", "Ukobach", "Uphir", "Uvall", "Valafar", "Vepar", "Verdelet", "Verin", "Vetis", "Xaphan", "Zagan", "Zepar"
                };

            MetalWords = new List<string>
            {
                "Death", "Black", "Dark", "Blood", "Dead", "Hell", "War", "Necro", "Soul", "Night", "Fall", "Hate", "God", "Evil", "Kill", "Fire", "Storm", "Rain", "Lord", "Head", "Metal", "Human", "Light", "Moon", "Winter", "Shadow", "Demon", "Satan", "Pain", "Eternal", "Dream", "Burn", "Witch", "Chaos", "Flesh", "Cult", "Goat", "Rage", "Terror", "Force", "Fear", "Throne", "Wolf", "Stone", "Christ", "Steel", "Rot", "Funeral", "Torment", "Ritual", "Cross", "Gate", "Frost", "Gore", "Doom", "Corpse", "Beyond", "Crypt", "Infernal", "Wind", "Brain", "Lost", "Grim", "Ash", "Iron", "Face", "Raven", "Spirit", "Morbid", "Forest", "Sick", "Cold", "Skull", "Anger", "Fuck", "Fallen", "Grind", "Devil", "Ruin", "Thrash", "Suffer", "Murder", "Divine", "Slaughter", "Brutal", "Child", "Nocturnal", "Sorrow", "Psycho", "Torture", "Torment", "Wrath", "Serpent", "Agony", "Slave", "Heaven", "Circle", "Grace", "Noise", "Ancient", "Dragon", "Hand", "Slut","Whore","Bitch","Cunt", "Master", "Rotten", "Rotting", "Phantom", "Revenant"
            };

        }

        public static string Chaine(int i)
        {
            string output = "";
            for (int j = i - 1; j >= 0; j--)
            {
                output += " " + LipsumWords[rand.Next(LipsumWords.Count)];
            }
            return output;
        }

        public static string Nom()
        {
            string str = DemonWords[rand.Next(DemonWords.Count)].ToLower() + " " + MetalWords[rand.Next(MetalWords.Count)].ToLower() + " " + MetalNames[rand.Next(MetalWords.Count)].ToLower();
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str);

        }

        public static int Nombre()
        { return rand.Next(1000); }

        public static int Nombre(int i)
        { return rand.Next(i); }

        public static int Nombre(int i, int j)
        { return rand.Next(Math.Abs(j - i)) + Math.Min(i, j); }


        public static bool Booleen()
        {
            return (rand.Next(10) >= 5);
        }

        public static DateTime DateFuture()
        {
            return DateTime.Now.AddDays(rand.Next(100));
        }
        public static DateTime DatePassee()
        {
            return DateTime.Now.AddDays(rand.Next(100) - 100);
        }
    }
}