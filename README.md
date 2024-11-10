# LieDetectorCorp_PSM
Detail Presentation Link: 
"Advanced Lie Detection System using Physiological Data (Heart Rate, GSR) and Polygraph Analysis".
Project Structure Link : https://1drv.ms/w/c/296f329ba0b4d20f/EZrcB2HhZG1AjwHyJGW3eLYBtDs1iZw3rNHI-QkoQOVgFQ?e=5a7BJ2
Organize the codebase in a clear and intuitive structure:

bash
Copy code
LieDetectorCorp/
├── src/
│   ├── LieDetectorAPI/         # ASP.NET Core Web API project
│   ├── LieDetectorUI/          # Frontend: HTML/CSS/JavaScript
│   └── Tests/                  # NUnit & Selenium Test Files
├── docs/                       # Documentation (for BRS, FRS, SRS)
├── assets/                     # Diagrams, images, charts for project showcase
├── LICENSE                     # License file
└── README.md                   # Project introduction & details

# Lie Detector Corp - Advanced Lie Detection System

This project provides a comprehensive lie detection solution utilizing physiological data such as heart rate and galvanic skin response (GSR). Built using ASP.NET Core Web API, the system offers both in-person and remote lie detection capabilities.

[![Build Status](https://img.shields.io/badge/build-passing-brightgreen)](link) [![GitHub issues](https://img.shields.io/github/issues/user/repo)](link)

## Features:
- **Polygraph Integration:** Monitors heart rate, blood pressure, GSR, and respiratory rate.
- **Remote Lie Detection:** Secure online assessments with real-time results.
- **Corporate and Legal Support:** Background checks, fraud detection, and case evaluation.

## Screenshots
### Web In![Screenshot 2024-11-09 233050](https://github.com/user-attachments/assets/5964521f-78b9-4758-af97-420d89837307)
terface:
![Dashboard]()

### Testing Results:
![NUnit Tests]()![Screenshot 2024-11-09 224555](https://github.com/user-attachments/assets/3ccc1d6b-0d10-4b07-b8ba-6c5e157de4ae)

## Installation

1. Clone the repository:
   ```bash
   git clone ## Installation

1. Clone the repository:
   ```bash
   git clone (https://github.com/PSivaMallikarjun/LieDetectorCorp_PSM)
Navigate to the project directory and install dependencies:

bash
Copy code
cd LieDetectorCorp/src/LieDetectorAPI
dotnet restore
Run the project:

bash
Copy code
dotnet run
Run tests using NUnit and Selenium:

bash
Copy code
cd ../Tests
dotnet test
For more detailed instructions, refer to the documentation.

yaml
Copy code

---

4. Documentation (BRS, FRS, SRS, etc.)
Use a `docs/` directory for your detailed documentation. For example:

- Business Requirements (BRS): Describes what the system should achieve from a business perspective.
- Functional Requirements (FRS): Explains the functionality of each module.
- Software Requirements (SRS): Defines the technical and non-functional requirements.

Make these documents accessible and link them in the `README.md`:
```markdown
Documentation
- [Business Requirements Specification (BRS)]
- [Functional Requirements Specification (FRS)]
- [Software Requirements Specification (SRS)]
**Business Requirements Specification (BRS)**
1. Project Overview
The LieDetectorCorp project aims to develop an advanced lie detection system that leverages physiological signals such as heart rate, blood pressure, and Galvanic Skin Response (GSR) to accurately detect deception. The system will be designed for use by organizations, law enforcement, and legal entities, offering both on-site and remote testing capabilities. The project will provide corporate services for employee screening, legal case support, and fraud detection.

2. Business Objectives
Provide reliable and scientifically proven lie detection services.
Offer both in-person and remote lie detection solutions.
Ensure the confidentiality and security of all user data.
Deliver high-quality, user-friendly, and customizable lie detection solutions for various industries.
Enable integration with corporate and legal systems for streamlined operations.
3. Key Stakeholders
Primary Users: Law enforcement agencies, corporate HR departments, legal professionals, and individuals seeking lie detection services.
System Administrators: Internal team responsible for system maintenance and support.
Business Owners: LieDetectorCorp executives overseeing business operations.
Third-Party Integrators: Partners for future API and service integration (if applicable).
4. Success Metrics
High accuracy in lie detection results.
Positive user feedback on the ease of use and reliability of the system.
Increase in business adoption of lie detection services, especially remote solutions.
Secure handling of sensitive user data.
**Functional Requirements Specification (FRS)**
1. Functional Overview
The system will provide different types of lie detection services, including Polygraph-based detection, heart rate & GSR monitoring, and customized corporate solutions. It will feature a secure interface for users to input data, receive feedback, and view results.

2. Core Features
2.1 Polygraph Lie Detection
Inputs: Heart rate, blood pressure, respiratory rate, and GSR.
Processing: Real-time data collection and analysis using polygraph algorithms.
Output: Detailed report indicating truthfulness based on physiological data.
2.2 Heart Rate & GSR Lie Detection
Inputs: Heart rate and GSR data collected via non-invasive sensors.
Processing: Quick analysis of stress and deception indicators.
Output: Results showing potential signs of deception.
2.3 Remote Lie Detection
Inputs: Heart rate and GSR data collected remotely via secure channels.
Processing: Real-time processing of remote data.
Output: Immediate results with a full report available for download.
2.4 Custom Corporate & Legal Services
Inputs: Case-specific data for legal or corporate investigations.
Processing: Tailored analysis based on user needs (e.g., employee background checks, fraud detection).
Output: Customized reports for corporate/legal use.
3. Non-Functional Requirements
Security: All user data must be encrypted during transmission and storage.
Performance: The system must process and deliver results in real-time for on-site tests and within a few minutes for remote tests.
Usability: The user interface must be intuitive and accessible for both technical and non-technical users.
Reliability: The system should be available 99.9% of the time with minimal downtime.
Scalability: The system should handle multiple users concurrently without degradation in performance.
4. User Roles
Admin Users: Full access to system configuration and all data.
Standard Users: Limited access to perform lie detection tests and view results.
Corporate Users: Access to company-specific tests and reports.
Remote Users: Access to remote lie detection tools and reports.
**Software Requirements Specification (SRS)**
1. Introduction
This document specifies the technical and functional requirements for the LieDetectorCorp lie detection system. It outlines the architecture, system components, and detailed functionalities required for the system to operate efficiently and securely.

2. System Architecture
2.1 Overview
The system will be based on an ASP.NET Core Web API, with a frontend built using HTML, CSS, and JavaScript. Data collection will be done via IoT sensors connected to users for heart rate, blood pressure, and GSR monitoring. The backend will include real-time data processing, storage, and reporting features.

3. Functional Requirements
3.1 User Authentication
Description: Users must authenticate via username and password to access services.
Requirement: OAuth2 or JWT-based authentication for secure login.
3.2 Data Collection
Description: Collect physiological data (heart rate, blood pressure, GSR).
Requirement: Support for data collection from sensors via Bluetooth or USB connections.
3.3 Data Analysis
Description: Real-time analysis of physiological data to detect patterns associated with deception.
Requirement: Use machine learning algorithms and pattern recognition for data processing.
3.4 Result Generation
Description: Generate reports based on collected data.
Requirement: Reports should include visual aids such as graphs, tables, and a summary of results.
3.5 Remote Access
Description: Enable users to perform lie detection tests remotely via a web interface.
Requirement: Support real-time data streaming and remote sensor integration.
4. Non-Functional Requirements
4.1 Performance
Description: The system must handle high volumes of data efficiently.
Requirement: System latency must not exceed 2 seconds for real-time data analysis.
4.2 Security
Description: All data must be encrypted and stored securely.
Requirement: Use AES encryption for data storage and TLS for data transmission.
4.3 Availability
Description: The system must be available 24/7.
Requirement: Implement load balancing and redundancy to ensure high availability.
4.4 Scalability
Description: The system should be able to scale to accommodate increasing user numbers.
Requirement: Use cloud-based services for dynamic scaling (e.g., Azure or AWS).
4.5 Data Privacy Compliance
Description: The system must comply with data privacy laws such as GDPR.
Requirement: Ensure users can opt-in/opt-out of data storage and access their personal information.
Agile Process for the Project
1. Sprints and Iterations
The development of the LieDetectorCorp project will follow Agile methodology, broken down into several sprints:

Sprint 1: Setting up infrastructure, database design, user authentication, and API setup.
Sprint 2: Data collection and real-time analysis feature implementation.
Sprint 3: Developing remote access and testing capabilities.
Sprint 4: Report generation, dashboard creation, and UI/UX improvements.
Sprint 5: Final testing (including unit testing, regression testing with NUnit and Selenium).
Sprint 6: Deployment, scalability testing, and production release.
2. Scrum Meetings
Daily stand-ups to track progress, identify blockers, and discuss any backlog items.

3. Backlog Management
Using tools like Jira or Azure DevOps to manage the product backlog, prioritize user stories, and track bug fixes.

4. Testing Process
Unit testing, regression testing (with NUnit and Selenium), and continuous integration testing will be performed at the end of each sprint to ensure system functionality and reliability.
Automated Testing (NUnit, Selenium)
Demonstrate the robustness of your system by showcasing automated tests. You can create a badge for test status:

markdown
Copy code
[![Test Status](https://img.shields.io/badge/tests-passing-brightgreen)](link)

Testing
We use NUnit for unit testing and Selenium for automated browser testing.

Running Tests
1. Navigate to the `Tests` folder:
   ```bash
   cd src/Tests
Run the tests using NUnit:
bash
Copy code
dotnet test
Selenium-based tests are in RegressionTests.cs.
yaml
Copy code

Include code snippets of important test cases in the `README.md` or separate markdown files like `TESTS.md`.

---

 6. Issues and Contributions
Encourage collaboration by explaining how others can contribute or report issues:
```markdown
 Contributing
We welcome contributions from the community. Please follow the [contribution guidelines](CONTRIBUTING.md).

 Issues
If you encounter any issues, feel free to open a ticket in the [Issues Section](https://github.com/PSivaMallikarjun)

