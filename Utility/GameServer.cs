namespace Utility;

public class GameServer
{
    
    public class Player
    {
        public string name;
        public int level;
        public int health;
        public bool isVip;
        public Clan clan;
    }
    
    
    
    // 5000 |        // ------------------------------------------------
                     // Memory Address of where the name of the player is stored
    // 5004 |        // ------------------------------------------------
    // 5008 |    0C               00            00            00
    // 5012 |    64               00            00            00
    // 5016 |    01               --            --            --
    // 5020 |        // ------------------------------------------------
    //               // Memory Address of where the clan is stored
    // 5004 |        // ------------------------------------------------
    
    
    // Binary serialization of players (33 bytes)
    // cM ca cr cc 00 00 00 00  // 8 chars of name
    // 00 00 00 00 00 00 00 00  // 8 chars of name
    // 00 00 00 00 00 00 00 00  // 8 chars of name
    // 00 00 00 00 00 00 00 00  // 8 chars of name
    // 0C 00 00 00 64 00 00 00  // 4 bytes level, 4 bytes health
    // 01                        // 1 byte isVip
    
    
    
    /*
     * xml serialization (195 bytes)
      <?xml version="1.0" encoding="utf-8"?>
       <Player>
           <name>Marc</name>
           <level>12</level>
           <health>100</health>
           <isVip>true</isVip>
           <clan>
               <id>5767</id>
           </clan>
       </Player>
     */
    
    
    /*
     * json (compact) (71 bytes)
     *
     * {"name":"Marc","level":12,"health":100,"isVip":true,"clan":{"id":5767}}
     * 
     */
    
    
    /*
     * as yaml (81 bytes)
     *
     * player:
       name: Marc
       level: 12
       health: 100
       isVip: true
       clan:
         id: 5767
     */

    public class Clan
    {
        public int id;
        public string name;
    }

    public static void SavePlayer()
    {
        Clan clan = new Clan();
        clan.name = "The Cool Dudes";
        
        Player player = new Player();
        player.name = "Dude";
        player.level = 12;
        player.health = 100;
        player.clan = clan;
        player.isVip = true;

        Console.WriteLine(player);
    }
}