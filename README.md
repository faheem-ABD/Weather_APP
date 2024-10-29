# Weather_APP
Weather fetching application with C# and React

The API is accessed from OPEN WEATHER

Document to call the API link : https://openweathermap.org/api/one-call-3
To call : 
https://api.openweathermap.org/data/3.0/onecall/timemachine?lat={lat}&lon={lon}&dt={time}&appid={API key} but to call wiith citynames we use GeoCode APi call 
https://api.openweathermap.org/data/2.5/weather?q={city name}&appid={API key}


when the API key is used for example weather report for a city name (Testing reason) we can get a sample output

https://api.openweathermap.org/data/2.5/weather?q=Stockholm&appid=1d31a112a07859256b5755963bfbb03b

we get : 

"coord":{"lon":18.0649,"lat":59.3326},"weather":[{"id":803,"main":"Clouds","description":"broken clouds","icon":"04n"}],"base":"stations","main":{"temp":283.17,"feels_like":282.45,"temp_min":282.4,"temp_max":283.74,"pressure":1008,"humidity":85,"sea_level":1008,"grnd_level":1003},"visibility":10000,"wind":{"speed":6.69,"deg":260},"clouds":{"all":75},"dt":1730244480,"sys":{"type":1,"id":1788,"country":"SE","sunrise":1730268160,"sunset":1730300396},"timezone":3600,"id":2673730,"name":"Stockholm","cod":200}

