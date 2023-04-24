import java.util.Scanner;
public class Main
{
    // 6.Вводится натуральное число n. На следующей строчке вводятся n целых чисел. Считайте их как массив на n элементов. 
    // на следующей строке вводятся два индекса: l и r. Найдите среднее арифметическое всех элементов с индексами от l
    //  до r включительно. Выведите в ответ одно действительное число. Гарантируется, что 0 <= l <= r < n.
	public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);
	System.out.println("Введите количество элементов: ");
    int n = sc.nextInt();
    
    
    int[] arr = new int[n];
    System.out.println("Введите элементы:");
	for(int i = 0; i < arr.length; i++){
            arr[i] = sc.nextInt();
    }
    
    System.out.println("Введите 2 индекса массива: ");
    int l = sc.nextInt();
    int r = sc.nextInt();
    int sum = 0;
    double count = 0;
    for(int i = 0; i < arr.length; i++){
            
        sum+=arr[i];
            
    }
    count = sum/arr.length;
    System.out.println("AVG: " + count);
        
   
	
	
	
    

}  
}


