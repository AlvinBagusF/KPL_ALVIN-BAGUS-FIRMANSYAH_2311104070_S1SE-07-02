import tkinter as tk

def submit_action():
    nama = entry_nama.get()
    if nama:
        label_output.config(text=f"Halo {nama}!")
    else:
        label_output.config(text="Silakan masukkan nama.")

window = tk.Tk()
window.title("Program Halo Nama")
window.geometry("300x200")

entry_nama = tk.Entry(window, width=30)
entry_nama.pack(pady=10)

btn_submit = tk.Button(window, text="Submit", command=submit_action)
btn_submit.pack(pady=5)

label_output = tk.Label(window, text="")
label_output.pack(pady=20)

window.mainloop()
