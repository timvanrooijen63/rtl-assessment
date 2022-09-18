## TvMaze Scraper

The TvMaze Scraper tool consists of the following components:

* Elasticsearch. 
   This is the database of the application. It can be accessed on: http://elastic:rtl@localhost:9200

*  Logstash. 
   A logstash pipeline will import all required data to run the application 
  
* .net6 webapi. The webapi has a single endpoint: GET http://localhost:9001/shows?limit=2&offset=1
    
You can startup the whole application by running:
docker-compose up --build

PS The first time you run this application it can take some time before all docker images are downloaded. Please by patient and grab a coffee :)
First elasticsearch will come up and when this is ready a logstash pipeline will import all data.