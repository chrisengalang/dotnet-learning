namespace TodoConsoleApp.model;

public class Todo {
    private int id;
    private string title;
    private string progress;

    public int Id {
        get => id;
        set => id = value;
    }

    public string Title {
        get => title;
        set => title = value;
    }

    public string Progress {
        get => progress;
        set => progress = value;
    }
}