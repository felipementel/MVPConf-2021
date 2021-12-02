# acr.yml

- name: imageRepository \
  type: string

- name: dockerfilePath \
  type: string \
  default: **/Dockerfile

- name: acrServiceConnection \
  type: string \
  default: acr-mvpconf2021-dev

- name: tag \
  type: string \
  default: $(Build.BuildId)-dev

  ___

# dotnet-build.yml
parameters:
- name: slnPath \
  type: string \
  default: src/*.sln

- name: buildConfiguration \
  type: string \
  default: Release \
  values: [Release, Debug]

  ___

# dotnet-restore.yml
parameters:
- name: slnPath \
  type: string \
  default: '**/*.sln'

  ___

# dotnet-restore-v2.yml

parameters:
- name: slnPath \
  type: string \
  default: '**/*.sln'

- name: nugetPath \
  type: string \
  default: 'src/nuget.config'

  ___

# dotnet-test.yml

parameters:
- name: testsPath \
  type: string \
  default: '**/*Tests/*Tests.csproj' 

- name: testRunTitle \
  type: string \
  default: 'TITULO NÃO INFORMADO'

# dotnet-use.yaml

parameters:
name: version \
type: string \
values: [3.1.x, 5.0.x, 6.0.x]

# nuget.yml

parameters:
- name: packagesToPack \
  type: string

- name: packageName \
  type: string

- name: buildConfiguration \
  type: string \
  default: 'Release' \
  values: [Release, Debug]

# sonarqube-v1.yml

parameters:
- name: serverEndpoint \
  type: string

- name: projectKey \
  type: string

- name: projectName \
  type: string

- name: slnPath \
  type: string \
  default: src/*.sln

- name: buildConfiguration \
  type: string \
  default: Release \
  values: [Release, Debug]

# webapp.yml

parameters:
- name: webappName \
  type: string

- name: serviceConnectionAzure \
  type: string

- name: containerRegistry \
  type: string

- name: imageRepository \
  type: string

- name: tag \
  type: string \
  default: $(Build.BuildId)-dev

- name: resourceGroupName \
  type: string