from fastapi import FastAPI, Form
from passlib.context import CryptContext
from fastapi.middleware.cors import CORSMiddleware


app = FastAPI()

app.add_middleware(
    CORSMiddleware,
    allow_origins=["*"],
    allow_credentials=False,
    allow_methods=["*"],
    allow_headers=["*"],
)


pwd_context = CryptContext(schemes=["bcrypt"], deprecated="auto")

users = []


class User:
    def __init__(self, username, password):
        self.username = username
        self.password = self.hash_password(password)

    def hash_password(self, password):
        return pwd_context.hash(password)

    def verify_password(self, password):
        return pwd_context.verify(password, self.password)


@app.post("/register")
def register(username: str = Form(...), password: str = Form(...), confirm: str = Form(...)):
    # Check if user already exists
    for user in users:
        if user.username == username:
            return {"message": "User already exists", "status": 400}

    if password != confirm:
        return {"message": "Passwords do not match", "status": 400}


    new_user = User(username, password)
    users.append(new_user)

    return {"username": new_user.username, "message": "User registered successfully", "status": 201}


@app.post("/login")
def login(username: str = Form(...), password: str = Form(...)):
    # Find the user by username
    user = None
    for u in users:
        if u.username == username:
            user = u
            break

    if user is None:
        return {"error": "User not found", "status": 400}

    if user.verify_password(password):
        return {"message": "Login successful", "status": 201}
    else:
        return {"error": "Invalid password", "status": 400}

@app.get("/users")
def get_users():
    return {"users": users}


