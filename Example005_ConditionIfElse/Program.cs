Console.Write( "Ведите имя пользователя:  ");
string username = Console.ReadLine();

if (username.ToLower() == "даша")
{
    Console.Write( "Ура!! это же Даша" );
}
else
{
    Console.Write( "Привет, " );
    Console.WriteLine( username );
}