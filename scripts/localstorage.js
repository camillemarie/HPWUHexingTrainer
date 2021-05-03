
function BlazorSetLocalStorage(key, value) {
    localStorage.setItem(key, value);
}

function BlazorGetLocalStorage(key) {
    return localStorage.getItem(key);
}

function BlazorRegisterStorageEvent(component) {
    window.addEventListener("storage", async e => {
        await component.invokeMethodAsync("OnStorageUpdated", e.key);
    });
}
