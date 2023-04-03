import java.util.Scanner;
public class Main
{
    // 2.Напишите программу, которая выводит все двухзначные числа, делящиеся на 3 без остатка
	public static void main(String[] args) {
         for(int i=1; i<100; i++) {
            if(i%3 == 0) {
                System.out.println(i);
            }
        }

}  
}


