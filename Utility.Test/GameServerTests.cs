using NUnit.Framework;
namespace Utility.Test;
public class GameServerTests
{

    [Test]
    public void SavesPlayerCorrectly()
    {
        GameServer.SavePlayer();
    }
}