import java.util.Scanner;
import java.util.Random;
import java.util.Arrays;
public class Main {
    //8.Напишите программу, которая запрашивает у пользователя номер дня недели и выводит для этого дня его название.
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Введите день недели: ");
        int n = sc.nextInt();
        if(n == 1) {
            System.out.println("Понедельник");
        }
        else if(n == 2) {
                System.out.println("Вторник");
            }
        else if(n == 3) {
                System.out.println("Среда");
            }
       else if(n == 4) {
                System.out.println("Четверг");
            }
        else if(n == 5) {
                System.out.println("Пятница");
            }
        else if(n == 6) {
                System.out.println("Суббота");
            }
        else if(n == 7) {
                System.out.println("Воскресенье");
            }
        else {
            System.out.println("Error");
        }


    }
}