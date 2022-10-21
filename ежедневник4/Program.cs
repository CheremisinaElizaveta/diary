using ежедневник4;


List<Note> notes = new List<Note>();
Note note = new Note();
note.title = "1. играть на саксофоне";
note.text = " Играть на саксофоне";
note.into = "Описание: что это вообще но круто " +
    "Выполнить 18.10.2022";
note.created = new DateTime(2022, 10, 18);
notes.Add(note);

Note note2 = new Note();
note2.title = "1. купить пиццу";
note.text = " Купить пиццу";
note2.into = "Описание: не гавайскую!!!!!" +
    " Выполнить 23.10.2022";
note2.created = new DateTime(2022, 10, 23);
notes.Add(note2);

Note note3 = new Note();
note3.title = "1. смотреть ван пис";
note.text = " Смотреть Ван Пис";
note3.into = "Описание: 239 серия" +
    " Выполнить 22.10.2022";
note3.created = new DateTime(2022, 10, 22);
notes.Add(note3);

Note note4 = new Note();
note4.title = "1. выучить Мысева ";
note.text = " Выучить Мысева";
note4.into = "Описание: жеска учить процессор!!!!!!!!!!!!!!!!" +
    "Выполнить 22.10.2022";
note4.created = new DateTime(2022, 10, 19);
notes.Add(note4);

Note note5 = new Note();
note5.title = "1. отдыхать";
note.text = " Отдыхать";
note5.into = "Описание: какой отдыхать, негры работать (учить математику)" +
    " Выполнить 22.10.2022";
note5.created = new DateTime(2022, 10, 21);
notes.Add(note5);

DateTime date = DateTime.Now;
int position = 1;

while (true)
{

    ConsoleKeyInfo key = Console.ReadKey();

    if (key.Key == ConsoleKey.LeftArrow)
    {
        date = date.AddDays(-1);
    }
    else if (key.Key == ConsoleKey.RightArrow)
    {
        date = date.AddDays(1);
    }

    Console.Clear();
    Console.WriteLine("выбрана дата" + date.ToShortDateString());
    for (int i = 0; i < notes.Count; i++)
    {
        if (notes[i].created.Date == date.Date)
        {
            Console.WriteLine( notes[i].title);
            if (key.Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.WriteLine(notes[i].text);
                Console.WriteLine("--------------");
                Console.WriteLine(notes[i].into);
                Console.WriteLine("ДАТА: " + notes[i].created);
                

            }
        }
        
    }
    position = Strelka(key, position);

}


static int Strelka(ConsoleKeyInfo key, int position)
{
    if (key.Key == ConsoleKey.UpArrow)
    {
        position--;

    }

    if (key.Key == ConsoleKey.DownArrow)
    {
        position++;

    }
    Console.SetCursorPosition(0, position);
    Console.WriteLine("->");

    return position;
}







