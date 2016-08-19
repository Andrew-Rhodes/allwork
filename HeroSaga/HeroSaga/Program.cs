using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Data;
using Model;

namespace HeroSaga
{
    class Program
    {
        static void Main(string[] args)
        {
            using (HeroContext context = new HeroContext())
            {
                Character myCharacter = context.Characters.Find(1);

                Console.WriteLine(myCharacter.Name);
                Console.WriteLine(myCharacter.Description);
                Console.WriteLine(myCharacter.Age);
                Console.WriteLine(myCharacter.Alignment);

                myCharacter.Alignment = Alignment.Neutral;

                context.Characters.AddOrUpdate(myCharacter);
                context.SaveChanges();
                

                //Character character = new Character();
                //character.Name = "Bob";
                //character.Age = 12;
                //character.Alignment = Alignment.Chaotic;
                //character.Description = "Bad Ass";
                //character.Race = new Race() {Name = "Human"};
                //context.Characters.Add(character);
                context.SaveChanges();

            }


            using (HeroContext context = new HeroContext())
            {
                Monster myMonster = new Monster();

                myMonster.Name = "Randall";

                context.Monsters.AddOrUpdate();
                context.SaveChanges();
            }
                Console.ReadLine();

        }
    }
}
