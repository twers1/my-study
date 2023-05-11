import java.util.Scanner;
import java.util.Random;
import java.util.Arrays;
public class Main
{
   // 11. Напишите программу, где пользователь вводит пароль дважды. Если пароли совпадают вывести «пароль принят», 
   // если не совпадают «пароль не принят».
   
	public static void main(String[] args) {
        System.out.println("Добро пожаловать в терминал\nВведите пароль");
        
        String pass = "123qwerty";
        
        Scanner sc = new Scanner(System.in);
        String passTry = sc.nextLine();
        String passTry2 = sc.nextLine();
        
        if(pass == passTry && pass == passTry2) {
            System.out.println("Пароль принят");
        }
        else {
            System.out.println("Пароль не принят");
        }
        
            

}  
}


