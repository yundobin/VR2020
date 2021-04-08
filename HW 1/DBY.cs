using System;                                                                                                   // System을 사용함

namespace ConsoleApp1                                                                                           // 이름이 ConsoleApp1임
{
    class DBY                                                                                                   // DBY이라는 클래스사용
    {
        static void Main(string[] args)                                                                         // 메인함수 실행
        {
            if (args.Length > 0)                                                                                // 만약 args 로 받은 길이가 0보다 크면
            {
                for (int i = 0; i < args.Length; i++)                                                           // int i = 0 부터 args의 길이만큼
                {
                    Console.Write("*");                                                                         // "*" 을 출력
                    for (int j = 0; j < args[i].Length; j++)                                                    // int j = 0 부터 args배열의 i번째의 길이만큼
                    {
                        Console.Write("*");                                                                     // "*" 을 출력
                    }
                }
                Console.Write("***\n* ");                                                                       // "***\n* " 을 출력
                for (int i = 0; i < args.Length; i++)                                                           // int i = 0 부터 args의 길이만큼
                {
                    Console.Write(args[i] + " ");                                                               // args 배열의 i번째값을 부르고 한 칸 띄어 씀
                }
                Console.Write("*\n***");                                                                        // "*\n***" 을 출력
                for (int i = 0; i < args.Length; i++)                                                           // int i = 0 부터 args의 길이만큼
                {
                    Console.Write("*");                                                                         // "*" 을 출력
                    for (int j = 0; j < args[i].Length; j++)                                                    // int j = 0 부터 args배열의 i번째 길이만큼
                    {
                        Console.Write("*");                                                                     // "*" 을 출력
                    }
                }
            }
            Console.Write("\n10진수를 입력하세요 : ");                                                          // "\n10진수를 입력하세요 : " 를 출력
            int reverse = 0;                                                                                    // 뒤집은 값 저장할 정수
            int inputplus = 0;                                                                                  // 입력받은 값에 1111더한 값 저장할 정수
            int reverseplus = 0;                                                                                // 뒤집은 값에 1111더한 값 저장할 정수
            int result = 0;                                                                                     // 결과 값
            int[] intnum = new int[14];                                                                         // 숫자를 뒤집기 위한 int형 배열
            string input = Console.ReadLine();                                                                  // string input 을 Console의 ReadLine으로 받는다.
            input = input.Replace(",", "");                                                                     // input 에서 받은 "," 를 ""으로 재위치시킨다.
            try                                                                                                 // try
            {
                for (int i = 0; i < input.Length; i++)                                                          // int i = 0 부터 input의 길이만큼
                {
                    switch (input[i])                                                                           // switch로 intnum 배열에 값 부여
                    {
                        case '1':                                                                               // 1일때
                            intnum[i] = 1;                                                                      // intnum 배열의 i번째에 1을 넣음
                            break;                                                                              // 탈출
                        case '2':                                                                               // 2일때
                            intnum[i] = 2;                                                                      // intnum 배열의 i번째에 2를 넣음
                            break;                                                                              // 탈출
                        case '3':                                                                               // 3일때
                            intnum[i] = 3;                                                                      // intnum 배열의 i번째에 3을 넣음
                            break;                                                                              // 탈출
                        case '4':                                                                               // 4일때
                            intnum[i] = 4;                                                                      // intnum 배열의 i번째에 4를 넣음
                            break;                                                                              // 탈출
                        case '5':                                                                               // 5일때
                            intnum[i] = 5;                                                                      // intnum 배열의 i번째에 5를 넣음
                            break;                                                                              // 탈출
                        case '6':                                                                               // 6일때
                            intnum[i] = 6;                                                                      // intnum 배열의 i번째에 6을 넣음
                            break;                                                                              // 탈출
                        case '7':                                                                               // 7일때
                            intnum[i] = 7;                                                                      // intnum 배열의 i번째에 7을 넣음
                            break;                                                                              // 탈출
                        case '8':                                                                               // 8일때
                            intnum[i] = 8;                                                                      // intnum 배열의 i번째에 8을 넣음
                            break;                                                                              // 탈출
                        case '9':                                                                               // 9일때
                            intnum[i] = 9;                                                                      // intnum 배열의 i번째에 9를 넣음
                            break;                                                                              // 탈출
                        case '0':                                                                               // 0일때
                            intnum[i] = 0;                                                                      // intnum 배열의 i번째에 0을 넣음
                            break;                                                                              // 탈출
                    }
                }
                int output = Convert.ToInt32(input);                                                            // string input을 ToInt32를 사용하여 int값 output으로 변환
                if ((output <= 2147483647 && output >= 0))                                                      // 만약 output이 2147483647보다 작거나 같거나 output이 0보다 크거나 같을때
                {
                    Console.WriteLine("1. 입력받은 숫자 : " + input);                                           // "1. 입력받은 숫자 : " + input 을 출력
                    for (int i = 0; i < input.Length; i++)                                                      // int i = 0 부터 input의 길이만큼
                    {
                        reverse += intnum[i] * (int)Math.Pow(10, i);                                            // reverse 값에 intnum 배열의 i번째 수 * 10의 i 제곱을 더해준다.
                    }
                    Console.WriteLine("2. 숫자 뒤집기 : " + reverse);                                           // "2. 숫자 뒤집기 : " + reverse
                    inputplus = output + 1111;                                                                  // inputplus 에 output + 1111 한 값을 저장한다
                    reverseplus = reverse + 1111;                                                               // reverseplus 에 reverse + 1111 한 값을 저장한다
                    Console.WriteLine("3. 입력받은 숫자에 1111 더하기 : " + inputplus);                         // "3. 입력받은 숫자에 1111 더하기 : " + inputplus 를 출력한다.
                    Console.WriteLine("4. 뒤집은 숫자에 1111더하기 : " + reverseplus);                          // "4. 뒤집은 숫자에 1111더하기 : " + reverseplus 를 출력한다.
                    if (inputplus > reverseplus)                                                                // 만약 inputplus가 reverseplus 보다 크면
                    {
                        result = inputplus;                                                                     // result 값에 inputplus 값을 저장한다.
                    }
                    else if (reverseplus > inputplus)                                                           // 만약 reverseplus가 inputplus 보다 크면
                    {
                        result = reverseplus;                                                                   // result 값에 reverseplus 값을 저장한다.
                    }
                    else                                                                                        // 그렇지 않으면
                    {
                        Console.WriteLine("두 수의 값이 같습니다.");                                            // "두 수의 값이 같습니다." 를 출력한다.
                    }
                    Console.Write("5. 뒤집은 숫자와 입력받은 숫자중에 더 큰 숫자 : " + result);                 // "5. 뒤집은 숫자와 입력받은 숫자중에 더 큰 숫자 : " + result 를 출력한다.
                }
            }
            catch (IndexOutOfRangeException)                                                                    // IndexOutOfRangeException 오류를 잡아낸다.
            {
                Console.WriteLine("오류");                                                                      // "오류" 를 출력한다.
            }
            catch (FormatException)                                                                             // FormatException 오류를 잡아낸다.
            {
                Console.WriteLine("오류");                                                                      // "오류" 를 출력한다.
            }
            catch (OverflowException)                                                                           // OverflowException 오류를 잡아낸다.
            {
                Console.WriteLine("오류");                                                                      // "오류" 를 출력한다.
            }
        }
    }
}