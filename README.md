# OhanaSupport

Welcome!

## Installation and Setup

Install these programs

- git: https://git-scm.com/downloads
- .NET: https://dotnet.microsoft.com/download/dotnet/5.0
- VSCode: https://code.visualstudio.com/download
- Docker: https://www.docker.com/products/docker-desktop

### Git

1. Create a folder named GitHub at your user directory
2. Clone this project into Github folder (~/GitHub/OhanaSupport)
3. Create a file called .gitconfig in the ~/ directory (this is the folder above GitHub)
4. Put the following contents into it replacing github_username with your github username and github_account_email with your github accounts email
    ```
    [user]
        name = github_username
        email = github_account_email
    [commit]
        template = ~/.gitmessage
    [core]
        autocrlf = input
        whitespace = trailing-space,space-before-tab,indent-with-non-tab
    ```
5. Run this command from a terminal inside the OhanaSupport folder
    ```bash
    cp .gitmessage ~/.gitmessage
    ```

### VSCode

#### Install Extensions

##### Visual Configuration

1. vscode-icons: vscode-icons-team.vscode-icons

##### Language

1. C#: ms-dotnettools.csharp
2. Razor+: austincummings.razor-plus
3. YAML: redhat.vscode-yaml
4. TailwindCSS Intellisense: bradlc.vscode-tailwindcss
5. Github Markdown Preview (Extension Pack): bierner.github-markdown-preview
    - Markdown Preview Github Styling: bierner.markdown-preview-github-styles
    - Markdown Emoji: bierner.markdown-emoji
    - Markdown Checkboxes: bierner.markdown-checkbox
    - Markdown yaml Preamble: bierner.markdown-yaml-preamble

##### Container Tools

1. Docker: ms-azuretools.vscode-docker
2. Remote Containers: ms-vscode-remote.remote-containers
3. Kubernetes: ms-kubernetes-tools.vscode-kubernetes-tools

##### Other

1. Github Markdown Preview: bierner.github-markdown-preview
2. Remote Development: ms-vscode-remote.vscode-remote-extensionpack

##### LiveShare

1. Install Live Share Exension Pack (Extension Pack): ms-vsliveshare.vsliveshare-pack
    - Live Share: ms-vsliveshare.vsliveshare
    - Live Share Audio: ms-vsliveshare.vsliveshare-audio

#### Terminal Configuration

1. Click Terminal and open a new terminal
2. Click the dropdown v on the terminal
3. Choose the git bash
4. Exit the terminal and open a new terminal, this should open the git bash by default now

#### Open Project

1. Select 'Open Folder' and Select OhanaSupport, this will now open by default when you start VSCode

## Rules

### Commits

1. Never commit anything to the master branch
2. Always use the commit template (git commit) in the git bash and fill it out completely
3. Write your commits in present tense
4. Do not exceeed the width for the commit title or the commit description
5. Each commit should be a functional, test passing, deployable state
6. Do not include changes unrelated to the feature in your commits (i.e. adding identity to database, do not add in a refactor on the frontend renaming a css file)
5. Commits should tell a story of how you developed that feature

### Branches

1. Each feature/issue should have it's own branch
2. Link your branches to the issues in Github

### Issues

1. Create an issue for every feature/task group
2. Always update the Github issues
3. Every issue should have it's own branch
4. Close the issue on completion after being merged into master by the technical lead

## Agile Process

### Daily Scrum

Answer these 3 questions:
1. What did I accomplish?
2. What is blocking me from making progress?
3. What will I do next?

