using System;

public class VegetableStore
{
    private static VegetableStore instance;
    private VegetableStore()
    {
        Console.WriteLine("Создан новый овощной магазин.");
    }

    // Приватный конструктор, чтобы предотвратить создание экземпляров извне.
    public static VegetableStore GetInstance()
    {
        if (instance == null)
        {
            instance = new VegetableStore();
        }
        return instance;
    }

    public void SellVegetables()
    {
        Console.WriteLine("Проданы свежие овощи.");
    }
}

class Program
{
    static void Main()
    {

        VegetableStore store1 = VegetableStore.GetInstance();
        VegetableStore store2 = VegetableStore.GetInstance();

        // Проверка, что оба объекта указывают на один и тот же магазин.
        Console.WriteLine(store1 == store2); // Выведет True

        store1.SellVegetables();
    }
}
