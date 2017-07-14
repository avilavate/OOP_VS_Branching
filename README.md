## Samples contains a few patters where following practices are demonstrated:

### 1- Replacing branching in code:
       Replacing if-then-else conctruct with states (classes) that drives the decison making, sample uses 
       a simple Account balance managment scenario and handles different account states as frozen, closed 
       & active.
       
### 2- Replacing loops in code:    
       Sample takes a collection of Painters a shows how a linq query can be used to replacing looping, sample
       uses Painters selection scenario to find available, cheapest & fastest painter(s) from a collection 
       of painter.
       
### 3- Replacing Explicit IEnumerables from client code:
       Implementing Composite pattern and Instance method:
       public static T MinValueFinder<T, TIn>(this IEnumerable<T> list, Func<T, TIn> func)
            where T : class
            where TIn : IComparable<TIn> to find the painter based on the func passed to instance method 
            

At the end the client becomes light and easy and lightwaight as:
       
private static IPainter GetFastestPainter(double sqMeters, Painters painters) =>                             painters.GetAvailable().GetFastestOne(sqMeters);

private static IPainter GetCheapestPainter(double sqMeters, Painters painters) => painters.GetAvailable().GetCheapestOne(sqMeters);
        
private static Painters GetAllAvailablePainters(Painters painters) => painters.GetAvailable();
            
