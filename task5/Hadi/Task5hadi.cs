using System;

public class Class1
{
	public Class1()
	{
	}
    public bool MatchThePattern(string string1, string string2)
    {
        return ((string1.Substring(0, 1) == string1.Substring(1, 1)) && (string1.Substring(2, 1) == string1.Substring(3)) && (string2.Substring(0, 1) == string2.Substring(1, 1)) && (string2.Substring(2, 1) == string2.Substring(3)));
    }
            Console.WriteLine("( AABB ) , ( PPRR ) :>" +"\t" + MatchThePattern("AABB", "PPRR"));
            Console.WriteLine("( FFGG ) , ( ADAD ) :>" +"\t" + MatchThePattern("FFGG", "ADAD"));
            Console.WriteLine(Cs("FFGG", "ADAD"));
            Console.ReadLine();
}
