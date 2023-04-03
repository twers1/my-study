import java.util.Scanner;
public class Main
{
    // 5. Дано нечетное натуральное число n. 
    // Напишите программу, которая печатает равнобедренный звездный треугольник с основанием, равным n в соответствии с примером:
        public static void main(String[] args) {
            Scanner sc = new Scanner(System.in);
            System.out.println("Введите мне нечетное натуральное число: ");
            int n = sc.nextInt();
            for(int i = 0; i<=n; i++) {
                for(int j = 1; j<i+1;j++){ 
                    System.out.println("*");
                }
                System.out.println(" ");
            }
            for(int i = n - 1; i>=1;i-- ){
                for(int j = 1; j<=i+1; j++){
                    System.out.println("*");
                }
                System.out.println(" ");
            }
            
        }

}  


