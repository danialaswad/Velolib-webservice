Explications de la solution:
Nous avons un client Console utilisant un binding wsHttpBinding, ainsi qu'un client Windows Application Form utilisant un binding netTcpBinding.
L'utilisateur entre l'addresse de d�part et l'addresse de destination, � partir de ces informations le service lui fournit:
-Un itin�raire � pied de son adresse de d�part vers la station V�lib la plus proche ayant au moins un v�lo de disponible.
-Et un itin�raire � v�lo de la station V�lib jusqu'� l'adresse de destination indiqu�e par le client.

Le service utilise le web service Velib (carto et stationdetails) ainsi que deux web services Google Maps (Directions et Geocoding).
Le Geocoding est utilis� pour obtenir les coordonn�es � partir de l'adresse de d�part donn�e. A partir de ces coordonn�es et des donn�es obtenues avec les web service Velib, on trouve la station Velib la plus proche (en utilisant les coordonn�es et le service carto) qui poss�de au moins un V�lib de disponible (en utilisant le service stationdetails).
Ensuite on utilise le service Directions pour obtenir les deux itin�raires d�crits pr�c�demment.


Lancement du service et client:
