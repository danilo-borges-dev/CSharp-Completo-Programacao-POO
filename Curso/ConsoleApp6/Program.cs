using ConsoleApp6.Entities;
using static System.Console;

Animal jacare = new("Jacare Açu", "Reptil", 17);
Animal jacare2 = new("Jacare Açu", "Reptil", 20);
Animal jacare3 = new("Crocodilo", "Reptil", 70);
Animal jacare4 = new("Jacare Açu", "Reptil", 17);

WriteLine(jacare.Equals(jacare2));