using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algorithms.Sort
{
    public class MergeSort
    {
        public MergeSort() {
            Console.WriteLine("\nDivide and Conquer approach => MergeSort Algorithm, Theta(nlogn)");
        }
        public void merge(int[] arr, int left, int middle, int right)
        {
            //سه متغیر شمارنده
            int i, j, k;
            //طول زیرآرایه سمت چپ
            int n1 = middle - left + 1;
            //طول زیر آرایه سمت راست
            int n2 = right - middle;
            //تعریف زیرآرایه سمت چپ
            int[] L = new int[n1]; 
            //تعریف زیرآرایه سمت راست
            int[] R = new int[n2];

            //پرکردن زیر آرایه سمت چپ
            for (i = 0; i < n1; i++)
            {
                L[i] = arr[left + i];
            }
            //پرکردن زیر آرایه سمت راست
            for (j = 0; j < n2; j++)
            {
                R[j] = arr[middle + 1 + j];
            }

            //مقدار دهی مجدد 
            i = 0;
            j = 0;
            k = left;
            //بارگذاری مقادیر دو زیر آرایه بصورت مرتب شده در آرایه اصلی
            while (i < n1 && j < n2)  //تا زمانیکه یکی از زیر آرایه ها تمام شود
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }
            //بارگذاری باقیمانده زیر آرایه سمت چپ در آرایه اصلی
            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }
            //بارگذاری باقیمانده زیر آرایه سمت راست در آرایه اصلی
            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }
        public void mergeSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                //مرتب سازی بخش سمت چپ
                mergeSort(arr, left, middle);
                //مرتب سازی بخش سمت راست
                mergeSort(arr, middle + 1, right);

                merge(arr, left, middle, right);
            }
        }
    }
}
