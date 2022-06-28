using ProjetoParaTestes.Domain;
using Xunit;

namespace PorjetoParaTestes.Test;

public class UnitTest1
{

    [Fact]
    public void Test1()
    {
        Evento evento = new Evento();

        Assert.Equal(evento,evento);
    }
    
    [Fact]
    public void Test2()
    {
        Evento evento = new Evento();

        Assert.Equal(evento,evento);
    }
}