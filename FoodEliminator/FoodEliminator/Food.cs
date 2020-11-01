using SQLite;
using System;

public class Food
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Name{ get; protected set;}
}
