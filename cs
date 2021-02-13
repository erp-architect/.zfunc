cs()
{
    case $1 in
        "man")
            command open "https://docs.microsoft.com/en-us/dotnet/csharp/"
        ;;
       *)
            echo usage: cs [ man ]
        ;;
    esac
    
}