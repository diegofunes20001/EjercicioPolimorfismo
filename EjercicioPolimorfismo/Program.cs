using EjercicioPolimorfismo;

List<Animal> animals = new List<Animal>() {
     
    new Perro(),
    new Gato()

};
 Console.WriteLine("Ingrese de aminal es: ");
 Console.WriteLine(Console.ReadLine());

 foreach (Animal animal in animals)
 {
     animal.Speak();
     animal.Action();
 }

