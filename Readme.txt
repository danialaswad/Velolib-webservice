Explications de la solution:
Nous avons un client Console utilisant un binding wsHttpBinding, ainsi qu'un client Windows Application Form utilisant un binding netTcpBinding.
L'utilisateur entre l'addresse de départ et l'addresse de destination, à partir de ces informations le service lui fournit:
-Un itinéraire à pied de son adresse de départ vers la station Vélib la plus proche ayant au moins un vélo de disponible.
-Et un itinéraire à vélo de la station Vélib jusqu'à l'adresse de destination indiquée par le client.

Le service utilise le web service Velib (carto et stationdetails) ainsi que deux web services Google Maps (Directions et Geocoding).
Le Geocoding est utilisé pour obtenir les coordonnées à partir de l'adresse de départ donnée. A partir de ces coordonnées et des données obtenues avec les web service Velib, on trouve la station Velib la plus proche (en utilisant les coordonnées et le service carto) qui possède au moins un Vélib de disponible (en utilisant le service stationdetails).
Ensuite on utilise le service Directions pour obtenir les deux itinéraires décrits précédemment.


Lancement du service et client:
Exécuter le script LaunchConsoleClient.bat pour exécuter le client Console
Exécuter le script LaunchWAFClient.bat pour exécuter le client WAF

Si vous avez une System.IO.FileLoadException au lancement du script, Windows a bloqué automatiquement des fichiers et il faut les débloquer en faisaint clic droit -> Propriétés -> Cocher débloquer. Il faut le faire pour les fichiers suivants:
-WcfSvcHost.exe
-ServiceWCF\bin\Release\ServiceWCF.dll

Si cela ne fonctionne pas essayez de lancer les scripts en mode administrateur


Si les scripts ne fonctionnent toujours pas:
Ouvrir le projet VS fourni avec Visual Studio en mode administrateur
Lancer le projet ClientWAF pour lancer le client WAF en netTcpBinding
Lancer le projet ClientConsole pour lancer le client Console en wsHttpBinding