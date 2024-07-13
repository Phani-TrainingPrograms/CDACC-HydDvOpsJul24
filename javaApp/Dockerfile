# Docker File contains the instructions for the docker to load the required dependencies along with the code compilation , building and executing the app. All the required additional software can be downlaoded from docker hub. Except the OS, rest of the details requried for the app to run should be informed in the docker file. 
FROM openjdk:11
WORKDIR /var/www/java
COPY . /var/www/java/
RUN javac SampleFile.java
CMD exec java SampleFile 