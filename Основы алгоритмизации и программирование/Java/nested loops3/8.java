import java.util.Scanner;
public class Main
{
    // 8.Дано натуральное число n. Напишите программу, которая печатает численный треугольник в соответствии с примером:
	public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int n = sc.nextInt();
        for(int i = 0; i<=n; i++) {
            for(int j = 1; j<=i; j++){
                System.out.println(i);
            }
            System.out.println(" ");
        }

}  
}


