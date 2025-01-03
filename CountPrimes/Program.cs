// See https://aka.ms/new-console-template for more information

///Count Primes
///Given an integer n, return the number of prime numbers that are strictly less than n.
///

///Brute Force
///Time Complexity: O(n \sqrt{n})
///Space Complexity: O(1)
///
int CountPrimes(int n)
{
    int primeCount = 0;
    bool isPrime = true;
    if (n <= 2)
        return primeCount;

    for (int i = 2; i < n; i++)
    {
        for (int j = 2; j*j <= i; j++)
        {
            if (i % j == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
            primeCount++;
        isPrime = true;

    }
    return primeCount;
}

//Console.WriteLine(CountPrimes(10000));

///Optimal approach using Sieve of eratosthenes
///Time Complexity: O(n \log \log n)
///Space Complexity: O(n)
///
int CountPrimesOptimal(int n)
{
    int primeCount = 0;
    if (n <= 2)
        return primeCount;
    bool[] isPrime = new bool[n];

    for (int i = 2; i < n; i++)
    {
        // Assume all are primes
        isPrime[i] = true;
    }

    for (int i = 2; i * i < n; i++)
    {
        if (isPrime[i])
            for (int j = i * i; j < n; j+=i)
            {
                isPrime[j] = false;  //Multiples are marked as false
            }
    }

    // count primes
    for (int i = 2; i < n; i++)
    {
        if (isPrime[i])
            primeCount++;
    }
    return primeCount;
}

Console.WriteLine(CountPrimesOptimal(10000));

