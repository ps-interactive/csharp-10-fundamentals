string path = @"D:\data\";

bool directoryExists = Directory.Exists(path);

if (!directoryExists)
{ 
    Directory.CreateDirectory(path);
}

