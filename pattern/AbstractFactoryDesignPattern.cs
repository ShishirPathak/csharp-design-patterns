namespace AbstractFactoryDesignPattern;

public abstract class Factory {
    public abstract ILiteratureFactory MakeLiteratureFactory();
}

public interface IBook{
    public string GetGenre();
}

public class FictionBook : IBook{
    public string GetGenre(){
        return "Fiction Book";
    }
}

public class NonFictionBook : IBook{
    public string GetGenre(){
        return "Non Fiction Book";
    }
}

public interface ILiteratureFactory{
    IBook CreateBook();
}

public class FictionFactory : ILiteratureFactory
{
    public IBook CreateBook(){
        return new FictionBook();
    }
}

public class NonFictionFactory : ILiteratureFactory{
    public IBook CreateBook(){
        return new NonFictionBook();
    }
}

public class LiteratureAcademy : Factory
{
    public override ILiteratureFactory MakeLiteratureFactory(){
        return new FictionFactory();
    }
}