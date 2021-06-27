cs()
{
    case $@ in
        "man")
            command open "https://docs.microsoft.com/en-us/dotnet/csharp/"
        ;;
        "api")
            command open "https://docs.microsoft.com/en-us/dotnet/api/?view=net-5.0"
        ;;
        "ex -d")
            cd ~/csharp
        ;;
       *)
            echo "usage: cs [ man | api | ex -d ]"
        ;;
    esac
    
}