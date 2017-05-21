Explications de la solution:
Nous avons un client Console utilisant un binding wsHttpBinding, ainsi qu'un client Windows Application Form utilisant un binding netTcpBinding.
L'utilisateur entre l'addresse de d�part et l'addresse de destination, � partir de ces informations le service lui fournit:
-Un itin�raire � pied de son adresse de d�part vers la station V�lib la plus proche ayant au moins un v�lo de disponible.
-Et un itin�raire � v�lo de la station V�lib jusqu'� l'adresse de destination indiqu�e par le client.

Le service utilise le web service Velib (carto et stationdetails) ainsi que deux web services Google Maps (Directions et Geocoding).
Le Geocoding est utilis� pour obtenir les coordonn�es � partir de l'adresse de d�part donn�e. A partir de ces coordonn�es et des donn�es obtenues avec les web service Velib, on trouve la station Velib la plus proche (en utilisant les coordonn�es et le service carto) qui poss�de au moins un V�lib de disponible (en utilisant le service stationdetails).
Ensuite on utilise le service Directions pour obtenir les deux itin�raires d�crits pr�c�demment.


Lancement du service et client:
Ex�cuter le script LaunchConsoleClient.bat pour ex�cuter le client Console
Ex�cuter le script LaunchWAFClient.bat pour ex�cuter le client WAF

Si vous avez une System.IO.FileLoadException au lancement du script, Windows a bloqu� automatiquement des fichiers et il faut les d�bloquer en faisaint clic droit -> Propri�t�s -> Cocher d�bloquer. Il faut le faire pour les fichiers suivants:
-WcfSvcHost.exe
-ServiceWCF\bin\Release\ServiceWCF.dll

Si cela ne fonctionne pas essayez de lancer les scripts en mode administrateur


Si les scripts ne fonctionnent toujours pas:
Ouvrir le projet VS fourni avec Visual Studio en mode administrateur
Lancer le projet ClientWAF pour lancer le client WAF en netTcpBinding
Lancer le projet ClientConsole pour lancer le client Console en wsHttpBinding