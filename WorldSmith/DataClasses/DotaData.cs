﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using KVLib;
using System.Collections;

namespace WorldSmith.DataClasses
{
    static class DotaData
    {
        public static string KVHeader = "//This script generated by WorldSmith" + Environment.NewLine
            + "//Get WorldSmith at TODO: Put a URL here" + Environment.NewLine;


        public static string VPKPath = "dota_ugc" + Path.DirectorySeparatorChar + "game" + Path.DirectorySeparatorChar + "dota_imported" + Path.DirectorySeparatorChar + "pak01_dir.vpk";

        #region Unit Data Lists
        public static List<DotaUnit> AllUnits = new List<DotaUnit>();


        public static IEnumerable<DotaUnit> DefaultUnits = AllUnits.Where(x => x.ObjectInfo.ObjectClass == DotaDataObject.DataObjectInfo.ObjectDataClass.Default);

        public static IEnumerable<DotaUnit> OverriddenUnits = AllUnits.Where(x => x.ObjectInfo.ObjectClass == DotaDataObject.DataObjectInfo.ObjectDataClass.Override);

        public static IEnumerable<DotaUnit> CustomUnits = AllUnits.Where(x => x.ObjectInfo.ObjectClass == DotaDataObject.DataObjectInfo.ObjectDataClass.Custom);

        public static IEnumerable<DotaUnit> AllCustomUnits = OverriddenUnits.Union(CustomUnits);

        #endregion

        #region Hero Data Lists

        public static List<DotaHero> AllHeroes = new List<DotaHero>();

        public static IEnumerable<DotaHero> DefaultHeroes = AllHeroes.Where(x => x.ObjectInfo.ObjectClass == DotaDataObject.DataObjectInfo.ObjectDataClass.Default);

        public static IEnumerable<DotaHero> OverridenHeroes = AllHeroes.Where(x => x.ObjectInfo.ObjectClass == DotaDataObject.DataObjectInfo.ObjectDataClass.Override);

        public static IEnumerable<DotaHero> CustomHeroes = AllHeroes.Where(x => x.ObjectInfo.ObjectClass == DotaDataObject.DataObjectInfo.ObjectDataClass.Custom);

        public static IEnumerable<DotaHero> AllCustomHeroes = OverridenHeroes.Union(CustomHeroes);

        #endregion

        #region Ability Data Lists
        public static List<DotaAbility> AllAbilities = new List<DotaAbility>();

        public static IEnumerable<DotaAbility> DefaultAbilities = AllAbilities.Where(x => x.ObjectInfo.ObjectClass == DotaDataObject.DataObjectInfo.ObjectDataClass.Default);

        public static IEnumerable<DotaAbility> OverridenAbilities = AllAbilities.Where(x => x.ObjectInfo.ObjectClass == DotaDataObject.DataObjectInfo.ObjectDataClass.Override);

        public static IEnumerable<DotaAbility> CustomAbilities = AllAbilities.Where(x => x.ObjectInfo.ObjectClass == DotaDataObject.DataObjectInfo.ObjectDataClass.Custom);
              

        #endregion

        #region Item Data Lists
        public static List<DotaItem> AllItems = new List<DotaItem>();

        public static IEnumerable<DotaItem> DefaultItems = AllItems.Where(x => x.ObjectInfo.ObjectClass == DotaDataObject.DataObjectInfo.ObjectDataClass.Default);

        public static IEnumerable<DotaItem> OverridenItems = AllItems.Where(x=> x.ObjectInfo.ObjectClass == DotaDataObject.DataObjectInfo.ObjectDataClass.Override);

        public static IEnumerable<DotaItem> CustomItems = AllItems.Where(x=> x.ObjectInfo.ObjectClass == DotaDataObject.DataObjectInfo.ObjectDataClass.Custom);

        
        #endregion



        public static IEnumerable<DotaDataObject> AllClasses = AllUnits.Cast<DotaDataObject>()
            .Union(AllAbilities.Cast<DotaDataObject>())
            .Union(AllItems.Cast<DotaDataObject>());

        public static IList FindListThatHasObject(DotaDataObject ddo)
        {
            //I hate writing code like this


            DotaDataObject.DataObjectInfo.ObjectDataClass ObjectClass = ddo.ObjectInfo.ObjectClass;
            if (ddo is DotaHero)
            {
                return AllHeroes;
            }
            else if (ddo is DotaUnit)
            {
                return AllUnits;
            }
            else if (ddo is DotaItem)
            {
                return AllItems;
            }
            else if (ddo is DotaAbility)
            {
                return AllAbilities;
            }
            throw new ArgumentException("Don't have a list for that type");
        }

        public static string NPCScriptPath = "scripts" + Path.DirectorySeparatorChar + "npc" + Path.DirectorySeparatorChar;
        public static string CustomHeroesFile = NPCScriptPath + "npc_heroes_custom.txt";
        public static string CustomUnitsFile = NPCScriptPath + "npc_units_custom.txt";
        public static string CustomAbilityFile = NPCScriptPath + "npc_abilities_custom.txt";
        public static string CustomItemsFile = NPCScriptPath + "npc_items_custom.txt";

        public const string DefaultUnitsFile = "scripts/npc/npc_units.txt";
        public const string DefaultHeroesFile = "scripts/npc/npc_heroes.txt";
        public const string DefaultAbilitiesFile = "scripts/npc/npc_abilities.txt";
        public const string DefaultItemsFile = "scripts/npc/items.txt";

        #region HLLib Usage
        public static void LoadFromVPK(string vpkPath)
        {
            if (!Directory.Exists("cache")) Directory.CreateDirectory("cache");

            string path = Properties.Settings.Default.DotaDir + Path.DirectorySeparatorChar + VPKPath;
            HLLib.hlInitialize();

            // Get the package type from the filename extension.
            HLLib.HLPackageType PackageType = HLLib.hlGetPackageTypeFromName(path);

            HLLib.HLFileMode OpenMode = HLLib.HLFileMode.HL_MODE_READ |
                //HLLib.HLFileMode.HL_MODE_QUICK_FILEMAPPING |
                HLLib.HLFileMode.HL_MODE_VOLATILE;

            uint PackageID;

            ErrorCheck(HLLib.hlCreatePackage(PackageType, out PackageID));

            ErrorCheck(HLLib.hlBindPackage(PackageID));

            ErrorCheck(HLLib.hlPackageOpenFile(path, (uint)OpenMode));

        }


        private static string ReadTextFromHLLibStream(IntPtr Stream)
        {
            HLLib.HLFileMode mode = HLLib.HLFileMode.HL_MODE_READ;

            ErrorCheck(HLLib.hlStreamOpen(Stream, (uint)mode));

            StringBuilder str = new StringBuilder();

            char ch;
            while (HLLib.hlStreamReadChar(Stream, out ch))
            {
                str.Append(ch);
            }

            HLLib.hlStreamClose(Stream);

            return str.ToString();
        }

        public static string ReadAllText(string filePath)
        {
            IntPtr root = HLLib.hlPackageGetRoot();

            IntPtr file = HLLib.hlFolderGetItemByPath(root, filePath, HLLib.HLFindType.HL_FIND_FILES);

            IntPtr stream;
            ErrorCheck(HLLib.hlPackageCreateStream(file, out stream));

            string text = ReadTextFromHLLibStream(stream);

            return text;
        }

        public static void ErrorCheck(bool ret)
        {
            if (!ret)
            {
                MessageBox.Show("Error reading pak01_dir.vpk.\n\n The error reported was: " + HLLib.hlGetString(HLLib.HLOption.HL_ERROR_LONG_FORMATED), "Error opening .pak", MessageBoxButtons.OK);
                Shutdown();
                Properties.Settings.Default.AddOnPath = String.Empty;
                Properties.Settings.Default.Save();
                Environment.Exit(0);
            }
        }

        public static void Shutdown()
        {
            HLLib.hlShutdown();
        }

        #endregion

        #region LoadData
        public static void ReadScriptFromVPK<T>(string filePath, List<T> ListToInsert) where T : DotaDataObject
        {
            IntPtr root = HLLib.hlPackageGetRoot();

            IntPtr file = HLLib.hlFolderGetItemByPath(root, filePath, HLLib.HLFindType.HL_FIND_FILES);

            IntPtr stream;
            ErrorCheck(HLLib.hlPackageCreateStream(file, out stream));

            string unitsText = ReadTextFromHLLibStream(stream);

            KeyValue rootkv = KVLib.KVParser.ParseKeyValueText(unitsText);

            foreach (KeyValue kv in rootkv.Children)
            {
                if (!kv.HasChildren) continue; //Get rid of that pesky "Version" "1" key

                T unit = typeof(T).GetConstructor(new Type[] { typeof(KeyValue)}).Invoke(new object[] { kv }) as T;
              
                unit.ObjectInfo.FromVPK = true;
                unit.ObjectInfo.ObjectClass = DotaDataObject.DataObjectInfo.ObjectDataClass.Default;
                unit.ObjectInfo.OriginatingFile = filePath;

                ListToInsert.Add(unit);
            }
            return;
        }


        public static void ReadOverride<T>(string file, List<T> ListToLoadInto) where T : DotaDataObject
        {
            if (!File.Exists(Properties.Settings.Default.LoadedAddonDirectory + file)) return;

            try
            {
                KeyValue doc = KVParser.ParseKeyValueText(File.ReadAllText(Properties.Settings.Default.LoadedAddonDirectory + file));
                foreach (KeyValue kv in doc.Children)
                {
                    try
                    {
                        if (!kv.HasChildren) continue;
                        T unit = typeof(T).GetConstructor(new Type[] { typeof(KeyValue) }).Invoke(new object[] { kv }) as T;
                      
                        unit.ObjectInfo.FromVPK = false;
                        unit.ObjectInfo.OriginatingFile = file;
                        //TODO: Determine if it's an override
                        unit.ObjectInfo.ObjectClass = DotaDataObject.DataObjectInfo.ObjectDataClass.Custom;

                        ListToLoadInto.Add(unit);
                    }
                    catch (Exception e)
                    {
                        if (System.Diagnostics.Debugger.IsAttached) System.Diagnostics.Debugger.Break(); //Don't surpress errors when debugging

                        Console.WriteLine("ERROR in file:\"" + file + "\" on " + kv.Key);
                        Console.WriteLine(e.Message);
                        Console.WriteLine(e.StackTrace);
                        Console.WriteLine("");
                        Console.WriteLine("");
                    }
                }
            }
            catch (Exception e)
            {
                if (System.Diagnostics.Debugger.IsAttached) System.Diagnostics.Debugger.Break();

                //WE HAD A SYNTAX ERROR OR SOMETHING
                Console.WriteLine("SYNTAX ERROR in file:\"" + file + "\"");
                Console.WriteLine(e.Message);
                Console.WriteLine("");
                Console.WriteLine("");
            }
        }
        #endregion

        #region SaveData
        public static void SaveUnits()
        {
            SaveList(CustomUnits, "DOTAUnits", "npc_units_custom.txt");
            SaveList(OverridenHeroes, "DOTAHeroes", "npc_heroes_custom.txt");
            SaveList(CustomAbilities, "DOTAAbilities", "npc_abilities_custom.txt");
        }

        public static void SaveList<T>(IEnumerable<T> list, string RootKey, string outputFileName) where T : DotaDataObject
        {
            string path = Properties.Settings.Default.LoadedAddonDirectory + Path.DirectorySeparatorChar
                + "scripts" + Path.DirectorySeparatorChar + "npc" + Path.DirectorySeparatorChar;
            if (!Directory.Exists(path)) Directory.CreateDirectory(path);

            KeyValue doc = new KeyValue(RootKey);

            foreach (T unit in list)
            {
                doc += unit.SaveToKV();
            }

            File.WriteAllText(path + outputFileName, KVHeader + doc.ToString());
        }
        #endregion

        #region UnloadData
        public static void UnloadUnits()
        {
            AllUnits.Clear();
            AllItems.Clear();
            AllAbilities.Clear();
            AllHeroes.Clear();
        }
        #endregion


    }
}
