

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Collections;

namespace var6._1_kirichenkoilya
{
    public class Predmet
    {
        public string Word { get; set; } 
        public ArrayList Pages { get; set; } 

        public Predmet(string word, int page)
        {
            Word = word;
            Pages = new ArrayList() { page };
        }
    }


    public class PredUkaz
    {
        public ArrayList Items { get; private set; } = new ArrayList(); 


        public void Add(string word, int page)
        {
            var existingItem = Items.Cast<Predmet>().FirstOrDefault(item => item.Word == word);
            if (existingItem != null)
            {
                if (!existingItem.Pages.Contains(page) && existingItem.Pages.Count < 10)
                    existingItem.Pages.Add(page);
            }
            else
            {
                Items.Add(new Predmet(word, page));
            }
        }


        public void Edit(string oldWord, string newWord, ArrayList newPages)
        {
            var item = Items.Cast<Predmet>().FirstOrDefault(i => i.Word == oldWord);
                if (item.Word != null)
                {
                    item.Word = newWord; 
                    item.Pages = newPages;
                    return;
                }
            
        }


        public void Delete(string word)
        {
            var itemToRemove = Items.Cast<Predmet>().FirstOrDefault(item => item.Word == word);
            if (itemToRemove != null)
            {
                Items.Remove(itemToRemove);
            }
        }


        public void LoadFromFile(string path)
        {
            if (!File.Exists(path)) return;

            Items.Clear(); 
            foreach (var line in File.ReadAllLines(path))
            {
                var parts = line.Split(':');
                if (parts.Length != 2) continue;

                var word = parts[0].Trim();
                var pages = parts[1].Split(',').Select(p => int.Parse(p.Trim())).ToArray();

                var item = new Predmet(word, pages[0]);
                for (int i = 1; i < pages.Length && i < 10; i++)
                    item.Pages.Add(pages[i]);

                Items.Add(item); 
            }
        }


        public void SaveToFile(string path)
        {
            var lines = Items.Cast<Predmet>().Select(item => item.Word + ":" + string.Join(",", item.Pages.Cast<int>())).ToList();
            File.WriteAllLines(path, lines);
        }
    }
}


