import java.util.Scanner;
public class Main
{
    // 9.Напишите программу, которая по заданному с клавиатуры числу n 
    // печатает таблицу умножения от 1 до 9.
	public static void main(String[] args) {
         Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        for (int i = 1; i<=9; i++){
            System.out.println(n + " * " + i + " = " +  n*i);
        }

}  
}


