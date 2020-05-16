using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DugeonLibary
{

    public class Monster : Charecter
    {
        public int Damage { get; set; }
        public string _monsterType { get; set; }
    }
    public class Room
    {
        public string Description { get; set; }
        public List<Monster> RoomMonsters { get; set; }
    }

    public class RoomService
    {
        public Room GetRoom()
        {
            Room[] rooms = {
                roomFactory (
                //1
                "This room smells strange, no doubt due to the weird sheets of black slime that drip from cracks in the ceiling and spread across the floor. The slime seeps from the shattered stone of the ceiling at a snails crawl, forming a mess of dangling walls of gook. As you watch, a bit of the stuff separates from a sheet and drops to the ground with a wet plop.", 3),
                //2
                roomFactory ("This short hall leads to another door. On either side of the hall, niches are set into the wall within which stand clay urns. One of the urns has been shattered, and its contents have spilled onto its shelf and the floor. Amid the ash it held, you see blackened chunks of something that might be bone.", 2),
                //3
                roomFactory ("You open the door, and the room comes alive with light and music. A sourceless, warm glow suffuses the chamber, and a harp you cannot see plays soothing sounds. Unfortunately, the rest of the chamber isn't so inviting. The floor is strewn with the smashed remains of rotting furniture. It looks like the room once held a bed, a desk, a chest, and a chair.", 2),
                //4
                roomFactory ("A skeleton dressed in moth-eaten garb lies before a large open chest in the rear of this chamber. The chest is empty, but you note two needles projecting from the now-open lock. Dust coats something sticky on the needles' points", 3),
                //5
                roomFactory ("A dozen statues stand or kneel in this room, and each one lacks a head and stands in a posture of action or defense. All are garbed for battle. It's difficult to tell for sure without their heads, but two appear to be dwarves, one might be an elf, six appear human, and the rest look like they might be orcs.", 4),
                //6
                roomFactory ("A crack in the ceiling above the middle of the north wall allows a trickle of water to flow down to the floor. The water pools near the base of the wall, and a rivulet runs along the wall an out into the hall. The water smells fresh.", 3),
                //7
                roomFactory (" This short hall leads to another door. On either side of the hall, niches are set into the wall within which stand clay urns. One of the urns has been shattered, and its contents have spilled onto its shelf and the floor. Amid the ash it held, you see blackened chunks of something that might be bone.", 1),
                //8
                roomFactory (" A pungent, earthy odor greets you as you pull open the door and peer into this room. Mushrooms grow in clusters of hundreds all over the floor. Looking into the room is like looking down on a forest. Tall tangles of fungus resemble forested hills, the barren floor looks like a plain between the woods, and even a trickle of water and a puddle of water that pools in a low spot bears a resemblance to a river and lake, respectively.", 5),
                //9
                roomFactory ("A stone throne stands on a foot-high circular dais in the center of this cold chamber. The throne and dais bear the simple adornments of patterns of crossed lines -- a pattern also employed around each door to the room", 3),
                //10
                roomFactory ("When looking into this chamber, you're confronted by a thousand reflections of yourself looking back. Mirrored walls set at different angles fill the room. A path seems to wind through the mirrors, although you can't tell where it leads.", 4)
            };
            Random rand = new Random();
            int indexNbr = rand.Next(rooms.Length);

            Room room = rooms[indexNbr];

            return room;

        } //end class

        public Room roomFactory(string description, int monsterCount)
        {
            var monsterList = new List<Monster>() { };
            for (int i = 0; i < monsterCount; i++)
            {
                var monster = new Monster()
                {
                    Name = "Rat",
                    Life = 2,
                };
                monsterList.Add(monster);
            }

            return new Room()
            {
                Description = description,
                RoomMonsters = monsterList
            };
        }
    }
}
