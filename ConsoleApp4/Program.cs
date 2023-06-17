using System;
using System.Collections.Generic;

class HelloWorld
{
    static void Main()
    {
        Console.WriteLine("Welcome to Anime Selector");
        Console.WriteLine();

        bool selectAnotherGenre = true;

        List<string> watchLaterList = new List<string>();

        while (selectAnotherGenre)
        {
            Console.WriteLine("Select Your Preferred Genre");
            Console.WriteLine();
            Console.WriteLine("Select 1 to watch Shounen");
            Console.WriteLine("Select 2 to watch Isekai");
            Console.WriteLine("Select 3 to watch Sports");
            Console.WriteLine("Select 4 to watch Rom Com");
            Console.WriteLine();

            Console.WriteLine("Enter Genre: ");
            int choiceNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Genre You Selected is: " + choiceNum);
            if (choiceNum == 1)
            {
                Console.WriteLine("Shounen");
                Console.WriteLine();
                Console.WriteLine("These Are The Top 3 Shounen Anime You Can Watch");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1. Hunter x Hunter");
                Console.WriteLine("Overview:");
                Console.WriteLine("Hunter x Hunter is an anime about a boy named Gon who becomes a Hunter like his father, and together with his friends, they embark on adventures and battles in a complex and intriguing world of Hunters");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("2. One Piece");
                Console.WriteLine("Overview:");
                Console.WriteLine("One Piece is an anime about a young man named Monkey D. Luffy, who sets out on a journey to find the legendary treasure known as the One Piece and become the Pirate King. Along with his crew of misfits, he faces powerful enemies and navigates the treacherous waters of the Grand Line, all while searching for clues to the location of the treasure.");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("3. Naruto");
                Console.WriteLine("Overview:");
                Console.WriteLine("Naruto is an anime about a young ninja named Naruto Uzumaki who dreams of becoming the strongest ninja in his village and earning the respect of his peers. But Naruto carries a dark secret - he has the spirit of a powerful fox demon sealed inside him. As he trains and grows stronger, he faces dangerous enemies and uncovers secrets about his past and the hidden world of ninjas.");
                Console.WriteLine("--------------------------------");
                Console.WriteLine();

                AddToWatchLaterList(watchLaterList, "Shounen");
                selectAnotherGenre = PickAnotherGenre();
                Console.WriteLine();
            }
            else if (choiceNum == 2)
            {
                Console.WriteLine("Isekai");
                Console.WriteLine();
                Console.WriteLine("These Are The Top 3 Isekai Anime You Can Watch");
                Console.WriteLine();
                Console.WriteLine("1. Dr. Stone");
                Console.WriteLine("Overview:");
                Console.WriteLine(" Dr. Stone is a popular science-fiction anime series set in a post-apocalyptic world where a mysterious event has turned all of humanity into stone statues. Thousands of years later, a genius scientist named Senku Ishigami awakens from his petrified state and sets out to rebuild civilization with the power of science. Along with his friends, they embark on a quest to restore humanity's lost technology and uncover the secrets of the past. The show is known for its unique blend of science and action, as well as its charismatic and quirky characters.");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("2. Mushoku Tensei");
                Console.WriteLine("Overview:");
                Console.WriteLine("Mushoku Tensei is an isekai anime series about a 34-year-old unemployed man who is reincarnated into a fantasy world as a baby named Rudeus Greyrat. With the memories of his past life intact, Rudeus sets out to live a fulfilling life in this new world and become the strongest mage. Along the way, he learns magic and swordsmanship, makes new friends, and faces numerous challenges. The show is known for its mature themes and character development, as well as its stunning animation and world-building.");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("3. That Time I Got Reincarnated As A Slime");
                Console.WriteLine("Overview:");
                Console.WriteLine("That Time I Got Reincarnated As A Slime is an isekai anime series about a man named Satoru Mikami who is reincarnated as a slime monster in a fantasy world after being killed in his previous life. As a slime, Satoru gains a variety of unique powers and abilities and sets out to explore this new world. Along the way, he makes new friends, allies, and enemies, and becomes the leader of his own nation. The show is known for its lighthearted tone, creative world-building, and action-packed battles.");
                Console.WriteLine("--------------------------------");
                Console.WriteLine();

                AddToWatchLaterList(watchLaterList, "Isekai");
                selectAnotherGenre = PickAnotherGenre();
                Console.WriteLine();
            }
            else if (choiceNum == 3)
            {
                Console.WriteLine("Sports");
                Console.WriteLine();
                Console.WriteLine("These Are The Top 3 Sports Anime You Can Watch");
                Console.WriteLine();
                Console.WriteLine("1. Haikyu!");
                Console.WriteLine("Overview:");
                Console.WriteLine("Haikyu! is a sports anime about a high school student named Hinata who dreams of becoming a great volleyball player and joins his school's volleyball team to compete against other schools.");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("2. Kuroko No Basket");
                Console.WriteLine("Overview:");
                Console.WriteLine("Kuroko No Basket is a sports anime about a skilled basketball player named Kuroko who joins forces with a talented newcomer to challenge the former members of his legendary middle school basketball team.");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("3. Blue Lock");
                Console.WriteLine("Overview:");
                Console.WriteLine("Blue Lock is a sports anime about a young soccer player named Yoichi Isagi who is scouted by the Japanese Football Union to participate in a revolutionary program called Blue Lock, which aims to create the ultimate striker by pitting talented young players against each other in a high-pressure environment.");
                Console.WriteLine("--------------------------------");
                Console.WriteLine();

                AddToWatchLaterList(watchLaterList, "Sports");
                selectAnotherGenre = PickAnotherGenre();
                Console.WriteLine();
            }
            else if (choiceNum == 4)
            {
                Console.WriteLine("Rom Com");
                Console.WriteLine();
                Console.WriteLine("These Are The Top 3 Rom Com Anime You Can Watch");
                Console.WriteLine();
                Console.WriteLine("1. Kaguya-Sama Love Is War");
                Console.WriteLine("Overview:");
                Console.WriteLine("Kaguya-Sama Love Is War is a romantic comedy anime about two high school students, Kaguya Shinomiya and Miyuki Shirogane, who are the vice president and president of their school's student council. Despite their feelings for each other, they engage in a battle of wits and schemes to make the other confess their love first.");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("2. Horimiya");
                Console.WriteLine("Overview:");
                Console.WriteLine("Horimiya is a romance anime about a high school couple named Kyoko Hori and Izumi Miyamura, who seem to be completely different at school but have a secret life where they reveal their true selves to each other. As they navigate their relationship, they also encounter various challenges and struggles that they must overcome together.");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("3. Fruit Basket");
                Console.WriteLine("Overview:");
                Console.WriteLine("Fruits Basket is a heartwarming slice-of-life anime about a high school student named Tohru Honda who moves in with the Sohma family, who are cursed to turn into animals from the Chinese zodiac when hugged by someone of the opposite sex. As Tohru becomes friends with the Sohmas, she learns more about their curse, their past, and how to help them break free from their supernatural affliction.");
                Console.WriteLine("--------------------------------");
                Console.WriteLine();

                AddToWatchLaterList(watchLaterList, "Rom Com");
                selectAnotherGenre = PickAnotherGenre();
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid genre number.");
                Console.WriteLine();
            }
        }

        Console.WriteLine("Your Watch Later List:");
        foreach (string anime in watchLaterList)
        {
            Console.WriteLine(anime);
        }

        Console.WriteLine("Thank you for using Anime Selector!");
    }

    static void AddToWatchLaterList(List<string> watchLaterList, string genre)
    {
        Console.Write("Enter the number of the anime you want to save and watch later (5 to exit): ");
        int animeChoice = Convert.ToInt32(Console.ReadLine());

        if (animeChoice == 5)
            return;

        if (animeChoice >= 1 && animeChoice <= 3)
        {
            watchLaterList.Add(genre + " - Anime " + animeChoice);
            Console.WriteLine("Added to your watch later list.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid anime number.");
        }
    }

    static bool PickAnotherGenre()
    {
        Console.Write("Would you like to pick another genre? (yes/no): ");
        string pickAnotherGenre = Console.ReadLine();

        return pickAnotherGenre.ToLower() == "yes";
    }
}

