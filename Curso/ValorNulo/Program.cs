
////int? x = null;
////Nullable<int> y = null;

////string result = x == null ? "é nulo" : "não é nulo";

////Console.WriteLine(result);

//double? x = null;
//double? y = 10.0;

//Console.WriteLine(x.GetValueOrDefault());
//Console.WriteLine(y.GetValueOrDefault());

//Console.WriteLine();

//Console.WriteLine(x.HasValue);
//Console.WriteLine(y.HasValue);

//Console.WriteLine();

////Console.WriteLine(x.Value);
////Console.WriteLine(y.Value);

//string result = x.HasValue ? x.Value : "É nulo";
//Console.WriteLine(result);

double? x = null;

double y = x ?? x.GetValueOrDefault();

Console.WriteLine(y);

int numero = 10;
