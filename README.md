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


