public readonly struct Result<T> { 

public T Value { get; }

     public bool IsValidValue { get; }

    public Result(T value, bool isValidValue)
    {
         Value = value;
         IsValidValue = isValidValue;
    }

      public static Result<T> Negative(T value)
            => new(value, false);

      public static Result<T> Positive(T value)
            => new(value, true);
}

//https://www.reddit.com/r/csharp/comments/qmpruf/yo_dawg_i_heard_you_like_to_suppress_your/?utm_medium=android_app&utm_source=share
