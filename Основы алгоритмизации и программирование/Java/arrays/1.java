import java.util.Scanner;
public class Main
{
    // 1.Создайте массив, в котором будут храниться кубы чисел от 1 до 1000. 
    // Затем вводятся 2 числа из этого диапазона. Используя данные из массива найдите их кубы.
	public static void main(String[] args) {
        int[] arr = new int[1000];
        for(int i =1; i<1000; i++){
            arr[i] = i*i*i;
        }
        Scanner sc = new Scanner(System.in);
        int num1 = sc.nextInt();
        int num2 = sc.nextInt();
        int cub1 = arr[num1 - 1];
        int cub2 = arr[num2 - 1];
        System.out.println(cub1);
        System.out.println(cub2);

}  
}


