import java.util.Scanner;
public class Main
{
    // 2.Вводится натуральное число n. На следующей строчке вводятся n целых чисел. Напишите код, который создаст массив
    //  с именем array на n элементов, в котором буду храниться введённые числа (элемент массива равен соответствующему 
    // числу в во второй строке). На следующей строке вводится 2 числа - индексы элементов, сумму которых вам надо найти. 
    // Выведите на экран сумму этих двух элементов. Если вдруг индекс индекс оказался вне пределов диапазона от 0 до n - 1,
    //  то выведите на экран слово Error. 
	public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);
	System.out.println("Введите количество элементов: ");
    int n = sc.nextInt();
    
    
    int[] arr = new int[n];
    System.out.println("Введите элементы:");
	for (int i = 0; i < n; i++) {
	    arr[i] = sc.nextInt();
	} 
    
    System.out.println("Введите элемент массива: ");
    int temp = sc.nextInt();
    for(int i=1; i<temp;i++){
        System.out.println("Введите 2 числа - индексы элементов, сумму которых нужно найти: ");
        int a = sc.nextInt();
        int b = sc.nextInt();
         if(a < 0 || b > n - 1 || b < 0 || a > n - 1) {
            System.out.println("Error");
        }
        else {
            System.out.println(arr[a] + arr[b]);
        }
    }
   
	
	
	
    

}  
}


