# DevOps Training for CDAC-Hyd Batch July 24

## What is DevOps?
- DevOps is a mix of 2 words: Development and Operations. 
- There will be usually 2 teams who collaborate in the Product development Cycle(PDC). Developer Team and Operations Team. 
- The Dev Team will be responsible for the following things:
    - Requirement Gathering. 
    - Designing
    - Unit Testing
    - Development
    - Manual Testing. 
- The Dev Team also involves itself in integrating various parts of the Application and finally make it as a final product. Technically, your app is divided into modules(Packages, Dlls, Services, APIs) and there shall be one UI based Application that consume these modules.
- The important stake holders for the developer team would be Product Owners, Managers, Team Teads, Senior Programmers, Software programmers and QA Engineers(Testers). 
- The Operations team takes care of Deployment, Automation Testing that includes E2E Testing using automation tools and software like Selenium, Protractor(Web) and many more. This is followed by the final deployment into the Customer Environment. 
- The Ops team will be responsible for the following things:
    - Automation Testing 
    - Deployment. 
    - Customer Support. 
    - UAT(User accepetance test) will be done by one of the team members from the Customer end. He will be the one who undestands the process very well and also its requirements. These are the people who use the app on a daily basis. 
- The stake holders of the Ops team would be Automation Engineers, Product evaluators, UAT Engineers and Customer users who use the product. In some customer Organizations, we have Sp Engineers to evaluate UR App to suit their requirements. 

## Challenges in a regular Application Deployment
1. Many a time, the Ops team is unaware of the tech parts required for the app: which version of the framework that has been used, OS versions, dependencies, plugins and many more. Even a change in a config file, they are not aware of it. It used to take days together to resolve these minor issues. 
2. Integration of mutliple config files was a humongous task and would take weeks to resolve them. 
3. Apps are expected to be created partially, deployed and tested on the current setup instead of creating the whole app and finally testing it. Only during the final deployments, things were figured out and explained to the developers of the expectations which might have altered the actual development.
4. The solution to all such problems is : Devs + Ops = DevOps. 
5. Both the teams are expected to work from the begining till the end of the Product closure. From sprint planning, collaborative work, resolving deployment issues, config managements and many more. In this case, both the teams are aware of each other's work. The ops team will be with the dev team during the first cycle itself and their dependencies will gradually reduce over the time. 
6. As both the teams work together hand in hand, they understand the environment on both the ends, resolve the issues quickly instead of waiting till the end, the final deployment will be easier as both the teams are aware of the environment and they know on how to solve the issues if raised. 

## Why DevOps?
1. With Agile Development methodology practised across the industry, s/w is divided into small self deployable units and finally ported in a phased manner. 
2. With DevOps, S/w delivery is faster and easy. it increases the easiness of deployment. The tools of devops maintain an history of the previous deployments and teams has the expertise that can be utilized in the current deployment and with that experience, they can anticipate the future errors of that kind and work cautiously so that those issues dont arise. This makes both the development to develop the system in a careful manner and the Ops team is aware of handling such mistakes in a faster way. 

## How Apps are developed in current scenario. 
- With ADM, UR Scrum master will plan the Sprints with the Team lead. Each sprint includes a divided task on priority, resource Utilization and time taken for each task. Typically, the team would contain 1 Lead, 2 Sr. Engineers, 4 Jr. Engineers and 2 Testers. Initially the DevOps engineer wil be available full time to set up the process of CI/CD(Continuous Integration/Deployment). He shall use tools like Git(Source code Management), Jenkins(CI/CD Tool), Dockers(Containerizations) and K8s(KUBERNETES) for container management, Cloud Environment for servers and storage facilities.  

### Real time scenario:
1. Task: Get the Employee List from the database
2. Requirement: Mock a Database with the required data structure and create the Unit tests for it.  
3. Implement the Code by creating a class that performs the functionality on the actual database and then assert it with the unit tests The Unit test code will assert the results and ensure that the expected no of Employees in the list is matching the employee list of the Mocked database. 
4. Once the testing is completed(passed), Internal Reviews(IRs) are conducted and the Authorised person will push the code into the Repo(Code is sent to a centralized location server like Git, TFS, BitBucket...)
5. Once the code is pushed into the Repository, the Ops team uses a CI/CD tool to find the latest code update, pull it and run the build setup to ensure that the App is built properly in the required environment. 
6. As the Post build process, the App is placed in the pre-designated locations(cloud, docker container)
7. The management of such containers will be done by K8s. 

### Benifits of Using devOps
1. Productivity
2. Reproducability. 
3. Maintainability.

### Who needs DevOps?
1. DevOps are required for service based applications, large distributed Computing sofware apps like Ecommerce and ERP solutions where multiple users work at different time zones  and are maintiained in a cloud environment. 
2. Applications that use CI/CD tools and Agile methodologies need DevOps. 

### Major Devops tools
1. Git: For Repository Management
2. Jenkins: For CI/CD
3. Log4J and Splunk for Logging, Analytics and storing purposes
4. Docker for virtualizations of UR software
5. K8s for maintaining clusters of Docker Apps that run various parts of the Application. 

---------------------------------------------------------------------------------------------------------------------
### Docker: 
- Docker is a centralized platform for packaging, deploying and executing any app in a closed environment that is created to replicate the actual environment that was used to develop and execute the App. Typically works like VMs except Docker containers have only the min requirement to make the app work.
- It is a software platform that make UR apps building process into a smoother way which includes creating, running, testing and managing the app. U should not virtualize every part of the application into one docker. UR Database can reside inside another docker, Dlls can be in another docker and UR UI code would reside in another Docker. Using a XML based language called YAML, we can stitch all the dots of the various docker containers and link them to make an Application. 
- It uses a concept called CONTAINERS that creates a closed Environment for the App code to execute in that environment. Many such containers are connected to make a full length Application. 
- Container will have all the required dependencies that can be placed inside it or linked thru external containers and create a virtual environment that matches the real world software. In the real world, we install the software and dependencies on a hardware machine. Here it will be installed in a closed virtual environment. The OS part will be shared among the containers where the docker is installed. 
- Docker uses Linux kernel for its storage.
- For Windows, U must install WSL(Windows Subsystem for Linux) which is a prerequisite for installing Docker in UR machine To install the WSL, U can open the Cmd as Admin and run the install command
```
wsl --install
``` 
- U must restart the machine, then U can download the MSI file of the Docker from 
- Install the Docker Desktop from the link https://www.docker.com/products/docker-desktop/
- If required, U can add Path environment variable for executing Docker commands from the cmd. 
- Docker starts immediately after installation, however U can change the settings to start on request instead of Auto start.
- If the Cmd is already opened, U may have to restart it to execute the docker commands. 

## Using MongoDb from the Docker
1. Run the following commands in the order
```
docker pull mongodb/mongodb-community-server
docker run --name mongo -d mongodb/mongodb-community-server:latest
docker container ls
docker exec -it mongo mongosh
show dbs
```
### Assignment:
```
Create a Simple Java Application that uses Mongodb database taken from docker to display all the employee records from the database on Console. 
```
### Steps for installing a Java App as a container inside a Docker
1. Create a folder called javaApp
2. Develop the requried code for the javaApp. create a Sample class and do a hello world program. 
3. Build the App and test it. 
4. U must create the Dockerfile, a text file with no extensions. Provide the appropriate instructions
```
FROM openjdk:11
WORKDIR /var/www/java
COPY . /var/www/java/
RUN javac SampleFile.java
CMD exec java SampleFile 
```
5. Run the Docker commands to create the image and execute the Container. 
```
docker build -t java-app . 
docker run java-app
```
6. Options:
    - -t => to run the app in a virtual terminal so that U can see the results. 
    - -i => Use this option if U want the app run in interactive mode, when U expect User inputs from the Console Window. 


## Jenkins
### What is Continuous integration?
- It is an automatic process with a chain of activities that should be peformed when a code is pushed into a REPO and rest of the operations are taken up automatically that helps in pipelining the app build, testing and deploying along with some operational sequences that are done without an exclusive resource to monitor it. 
-<b>Linting:</b> U may sometimes have to validate the code that U have developed. This is called as LINTING. Solarlint is one of the popular linting tools. Linting is the automated checking of your source code for programmatic and stylistic errors. It is done using a Linting tool like Solarlint. 
- The CIT(Continuous Integration Tool) will be responsible to keep track on any cde changes that are pushed into the repo. It has a feature of triggering a series of tasks and finally do a post build task before terminating the process. 
- After the operations are completed in feel good mode, the post build operation will finally deploy the app on any container like Docker or a cloud server to be finally consumed by the End customers. here the QAT team of the Customer end will start testing the application and give the appropriate feedback. 
- It performs in a sequence where even of one of the teasks are failed, the rest f the operations will be stopped and the email notifications will be triggered to all the stake holders of the project to bring their attention and resolve it asap. 

### Jenkins?
- It is basically a Server side Application(developed uing JSP and Java) that runs on Apache tomcat server. It can be executed on multiple platforms. It is one of the most popular CIT available in the computing world. 
- Jenkins uses the concept of pipelines or group of tasks which work like a chain of operations. It has a continous process that monitors the environment at all time. 
- It uses a lot of 3rd party tools like Git, Sonarlint, ESlint, JUnit, NUnit and many more software performance monitoring tools that are invoked during the building cycle and ensure that the app is built with all the coding points in consideration. 

### Installation of Jenkins:
1. Download the appropriate JDK(v8.0 or later). 
2. Download the Jenkins from the website and install it. https://get.jenkins.io/windows-stable/2.452.3/jenkins.msi
3, During the installation, it shall ask the JRE location which U must select. 
4. U can optionally change the port no of the server to suit UR machine requirements. 
5. U can start the app by hitting http:\\localhost:portNo and login the App using default secret password shared at a predefined location: 
