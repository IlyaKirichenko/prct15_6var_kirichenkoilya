

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
    }
}


