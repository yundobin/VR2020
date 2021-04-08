using System;                                                                                       // System 을 사용
                                                                                                    
namespace DBY2                                                                                      // DBY2라는 파일명을 사용
{                                                                                                   // {
    class Program                                                                                   // 클래스는 Progrma 작성
    {                                                                                               // {
        static void Main(string[] args)                                                             // Main함수
        {                                                                                           // {
            int i;                                                                                  // 정수 i값                      
            int[] intNum = new int[15];                                                             // 로마숫자를 정수값으로 변환
            int[] encodeNum = new int[15];                                                          // 로마숫자의 번째수 ex) I = 1, V = 2, X = 3 ...
            int RomeCount = 0; int Up = 0; int Down = 0;                                            // RomeCount = 로마숫자가 반복된 횟수 Up = 커지는지 판별 Down = 작아지는지 판별
            int before = 0; int result = 0;                                                         // before(intNum)의 전 값 저장  result(결과값)을0으로 저장
            int min = 8; int max = 8;                                                               // min = (encodeNum의) 최소값 = 8. max = (encodeNum의) 최대값 = 8
            int RomeCompare;                                                                        // RomeCompare = encode[i]의 값을 저장
            bool CheckError = false;                                                                // 에러가 있는지 판별
            Console.Write("로마숫자를 입력해주세요");                                               // Console.Write("로마숫자를 입력해주세요"); 을(를) 출력
            String Rome = Console.ReadLine();                                                       // String Rome 값으로 입력받은값을 저장
            char[] RomeArray = Rome.ToCharArray();                                                  // Rome 값을 배열로 변경
            int RomeLength = Rome.Length;                                                           // Rome의 길이를 저장
                                                                                                    
                                                                                                    /*로마숫자를 십진수로 변환 시작*/
            for (i = 0; i < RomeLength; i++)                                                        // i는 0부터 RomeLength 만큼 반복
            {                                                                                       // {
                switch (RomeArray[i])                                                               // RomeArray[i]번째를 판단
                {                                                                                   // {
                    case 'I':                                                                       // 'I'인 경우
                        intNum[i] = 1;                                                              // intNum[i]의 값을 1(으)로 저장
                        encodeNum[i] = 1;                                                           // encodeNum[i]의 값을 1(으)로 저장
                        break;                                                                      // 탈출
                    case 'V':                                                                       // 'V'인 경우
                        intNum[i] = 5;                                                              // intNum[i]의 값을 5(으)로 저장
                        encodeNum[i] = 2;                                                           // encodeNum[i]의 값을 2(으)로 저장
                        break;                                                                      // 탈출
                    case 'X':                                                                       // 'X'인 경우
                        intNum[i] = 10;                                                             // intNum[i]의 값을 10(으)로 저장
                        encodeNum[i] = 3;                                                           // encodeNum[i]의 값을 3(으)로 저장
                        break;                                                                      // 탈출
                    case 'L':                                                                       // 'L'인 경우       
                        intNum[i] = 50;                                                             // intNum[i]의 값을 50(으)로 저장
                        encodeNum[i] = 4;                                                           // encodeNum[i]의 값을 4(으)로 저장
                        break;                                                                      // 탈출
                    case 'C':                                                                       // 'C'인 경우
                        intNum[i] = 100;                                                            // intNum[i]의 값을 100(으)로 저장
                        encodeNum[i] = 5;                                                           // encodeNum[i]의 값을 5(으)로 저장
                        break;                                                                      // 탈출
                    case 'D':                                                                       // 'D'인 경우
                        intNum[i] = 500;                                                            // intNum[i]의 값을 500(으)로 저장
                        encodeNum[i] = 6;                                                           // encodeNum[i]의 값을 6(으)로 저장
                        break;                                                                      // 탈출
                    case 'M':                                                                       // 'M'인 경우
                        intNum[i] = 1000;                                                           // intNum[i]의 값을 1000(으)로 저장
                        encodeNum[i] = 7;                                                           // encodeNum[i]의 값을 7(으)로 저장
                        break;                                                                      // 탈출
                    default:                                                                        // 이 외의 경우
                        Console.WriteLine("로마자가 아닌 다른 문자를 입력하였습니다.");                // "로마자가 아닌 다른 문자를 입력하였습니다." 을(를) 출력
                        CheckError = true;                                                          // 에러를 true로 설정
                        break;                                                                      // break
                }                                                                                   // }
            }                                                                                       // }
                                                                                                    /*로마숫자를 십진수로 변환 끝*/

                                                                                                    /*숫자에 오류 확인 시작*/
            RomeCompare = encodeNum[0];                                                             // RomeCompare에 encodeNum 배열의 첫번째 값을 저장
            for (i = 0; i < RomeLength; i++)                                                        // i는 0부터 RomeLength 만큼 반복
            {                                                                                       // {
                if (RomeCompare == encodeNum[i])                                                    // RomeCompare과 encodeNum 배열의 i번째 값이 같을때
                {                                                                                   // {
                    if (RomeLength != 1)                                                            // 만약 RomeLength의 길이가 1이 아니라면
                    {                                                                               // {
                        RomeCount++;                                                                // RomeCount 값에 1을 더한다.
                    }                                                                               // }
                    if(max == encodeNum[i])                                                         // max 값이 encodNum 배열의 i번째 값과 같으면
                    {                                                                               // {
                        if(RomeCompare %2 == 1 || RomeCount >=2)                                    // 만약 RomeCompare이 홀수이고 RomeCount가 2보다 크거나 같으면
                        {                                                                           // {
                            CheckError = true;                                                      // 에러를 true로 설정
                            break;                                                                  // 탈출
                        }                                                                           // }
                    }                                                                               // }
                    else                                                                            // 그렇지 않으면 
                    {                                                                               // {
                        if ((RomeCompare % 2 == 0 && RomeCount >= 2) || (RomeCompare % 2 == 1 && RomeCount >= 4))  // 만약 (RomeCompare이 짝수이고 RomeCount가 2)이거나(RomeCompare이 홀수이고 RomeCount가 4)이면
                        {                                                                           // {
                            CheckError = true;                                                      // 에러를 true로 설정
                            break;                                                                  // 탈출
                        }                                                                           // }
                    }                                                                               // }
                }                                                                                   // }
                else if (RomeCompare < encodeNum[i])                                                // RomeCompare보다 encodeNum 배열의 i번째 값이 클때
                {                                                                                   // {
                    if (RomeCount > 2 || Up > 1 || max < encodeNum[i] || (max % 2==0 && Down >=1))  // RomeCount가 2보다 클때, Up이 1보다 클때, max가 encodeNum 배열의 i번째보다 작을때,max 값이 짝수이고 Down 값이 1이상일때 
                    {                                                                               // {
                        CheckError = true;                                                          // 에러를 true로 설정
                        break;                                                                      // 탈출
                    }                                                                               // }
                    min = RomeCompare;                                                              // min 값에 RomeCompare 값을 대입
                    max = encodeNum[i];                                                             // max 값에 encodeNum 배열의 i번째 수를 대입
                    if (max % 2 == 1)                                                               // max 값을 2로 나누었을때의 나머지가 1이면 (홀수이면)
                    {                                                                               // {
                        if (max - min != 2)                                                         // 만약 max 값에서 min 값을 뺀게 2가 아닐때
                        {                                                                           // {
                            CheckError = true;                                                      // 에러를 true로 설정
                            break;                                                                  // 탈출
                        }                                                                           // }
                    }                                                                               // }
                    else                                                                            // 그렇지 않으면 max 값을 2로 나누었을때 나머지가 0이면 (짝수이면)
                    {                                                                               // {
                        if (max - min != 1)                                                         // 만약 max 값에서 min 값을 뺀게 1이 아닐때
                        {                                                                           // {
                            CheckError = true;                                                      // 에러를 true로 설정
                            break;                                                                  // 탈출
                        }                                                                           // }
                    }                                                                               // }
                    Up++;                                                                           // Up 값에 1을 더함
                    RomeCompare = encodeNum[i];                                                     // RomeCompare 값에 encodeNum 배열의 i번째 수를 대입
                }                                                                                   // }
                else                                                                                // 그렇지 않으면 RomeCompare보다 encodeNum 배열의 i 값이 작을때
                {                                                                                   // {
                    if (min <= encodeNum[i])                                                        // 만약 min 값이 encodeNum 배열의 i번째 수보다 작거나 같을때
                    {                                                                               // {
                        CheckError = true;                                                          // 에러를 true로 설정
                        break;                                                                      // 탈출
                    }                                                                               // }
                    max = RomeCompare;                                                              // max 값에 RomeCompare 값을 대입
                    if (RomeCompare % 2 == 0)                                                       // 만약 RomeCompare를 2로 나누었을때 나머지가 0이면 (짝수이면)
                    {                                                                               // {
                        if (RomeCount > 2)                                                          // 만약 RomeCount가 2보다 크면
                        {                                                                           // {
                            CheckError = true;                                                      // 에러를 true로 설정
                            break;                                                                  // 탈출
                        }                                                                           // }
                    }                                                                               // }
                    else                                                                            // 그렇지 않으면 RomeCompare를 2로 나누었을때 나머지가 1이면 (홀수이면)
                    {                                                                               // {
                        if (RomeCount > 4)                                                          // 만약 RomeCount가 4보다 크면
                        {                                                                           // {
                            CheckError = true;                                                      // 에러를 true로 설정
                            break;                                                                  // 탈출
                        }                                                                           // }
                    }                                                                               // }
                    Down++;                                                                         // Down 값에 1을 더함
                    RomeCount = 1;                                                                  // RomeCount 값을 1으로 설정
                    RomeCompare = encodeNum[i];                                                     // RomeCompare 값에 encodeNum 배열의 i번째 수를 대입
                }                                                                                   // }
            }                                                                                       // }
                                                                                                    /*숫자에 오류 확인 끝*/

                                                                                                    /*숫자 계산 시작*/
            if (CheckError != true)                                                                 // 만약 에러가 false라면
            {                                                                                       // {
                for (i = 0; i < RomeLength; i++)                                                    // i는 0부터 RomeLength 만큼 반복
                {                                                                                   // {
                    if (before < intNum[i])                                                         // 만약 before 값이 intNum 배열의 i 값보다 낮을때
                    {                                                                               // {
                        result += intNum[i] - 2 * before;                                           // result 값에 intNum 배열의 i번째 값에서 - (2 * before)값을 빼서 더한 수를 result 값에 넣는다
                        before = intNum[i];                                                         // before 값에 intNum 배열의 i번째 값을 대입한다.
                    }                                                                               // }
                    else                                                                            // 그렇지 않으면 before 값이 intNum 배열의 i 값보다 크거나 같을때
                    {                                                                               // {
                        result += intNum[i];                                                        // result 값에 intNum 배열의 i번째 값을 더한 수를 result 값에 넣는다
                        before = intNum[i];                                                         // before 값에 intNum 배열의 i번째 값을 대입
                    }                                                                               // }
                }                                                                                   // }
                Console.WriteLine("입력한 수 : " + result);                                         // "입력한 수 : " + result 을(를) 출력
            }                                                                                       // }
            else                                                                                    // 그렇지 않으면 에러가 true라면
            {                                                                                       // {
                Console.WriteLine("오류");                                                          // "오류"을(를) 출력
            }                                                                                       // }
                                                                                                    /*숫자 계산 끝*/
        }                                                                                           // }
    }                                                                                               // }
}                                                                                                   // }