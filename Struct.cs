using System;
namespace Classes_struct_and_namespaces
{
    public struct Struct
    {
        public string Direction;
        public int Miles;
        public void Display()
        {
            Console.WriteLine($"Направление : {Direction} , Расстояние : {Miles}");
        }

    }
    public struct Struct2
    {
        public Struct2(string MusicBandName , int Participants)
        {
            this.MusicBandName = MusicBandName;
            this.Participants = Participants;
        }
         string MusicBandName;
         int Participants;
        public void Display() => Console.WriteLine($"Название группы : {MusicBandName} , Количество участников : {Participants}");




    }
}
